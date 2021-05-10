using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using bakalarska_praca.Models;
using bakalarska_praca.Models.Auth;
using bakalarska_praca.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace bakalarska_praca.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private AuthServices _authService;
        private TokenServices _tokenService;

        public AuthController(AppDbContext appdbContext, IConfiguration config)
        {
            _appDbContext = appdbContext;
            _authService = new AuthServices(appdbContext);
            _tokenService = new TokenServices(appdbContext, config);
        }

        [HttpPost("/login")]
        public IActionResult Login([FromBody] Authenticate userModel)
        {
            var user = _authService.Authenticate(userModel);     //funkcia na overenie ci existuje uzivatel v DB

            if (user == null)           //zmenit na kontrolu hesla
            {
                return Unauthorized();
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.FirstName),
                new Claim(ClaimTypes.Surname, user.LastName),
                new Claim(ClaimTypes.Role, user.Role),
                new Claim(ClaimTypes.Email, user.Email),
            };
            var accessToken = _tokenService.GenerateAccessToken(claims);
            var refreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);

            _appDbContext.SaveChanges();
            return Ok(new
            {
                Token = accessToken,
                RefreshToken = refreshToken,
                Claims = claims
            });

        }

        [HttpPost("/register"), Authorize(Roles = "admin")]
        public IActionResult Register([FromBody] Register model)
        {
            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Role = model.Role
            };

            try
            {
                // create user
                //_authService.Create(user, model.Password);
                return Ok();
            }
            catch (Exception ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("/updateUser"), Authorize]
        public IActionResult UpdateUser([FromBody] UpdateUser model)
        {
            try
            {
                var user = _appDbContext.Logins.Where(o => o.Email == model.Email).Single();
                user.FirstName = model.Name;
                user.LastName = model.Surname;
                _appDbContext.Logins.Update(user);
                _appDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            return Ok();
        }
        [HttpPost("/updatePassword"), Authorize]
        public IActionResult UpdatePassword([FromBody] UpdateUser model)
        {
            try
            {
                var result = _authService.PasswordVerification(model);
                if (result == false)           
                {
                    return Unauthorized();
                }
                else
                {
                    return Ok();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}

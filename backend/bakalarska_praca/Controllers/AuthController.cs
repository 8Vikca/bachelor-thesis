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
    /// <summary>Controller <c>AuthController</c> works with methods about authentication</summary>
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

        /// <summary>Post method for user login</summary>
        /// <param name="userModel">password and email for the verification</param>
        /// <returns>OK() method if user is authenticated, otherwise Unauthorized()</returns>
        [HttpPost("/login")]
        public IActionResult Login([FromBody] Authenticate userModel)                       
        {
            /// <summary>Method for verification if user with given email exists</summary>
            var user = _authService.Authenticate(userModel);     

            if (user == null)           
            {
                return Unauthorized();
            }

            /// <summary>CLAIMS and Tokens creation</summary>
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

            /// <summary>Save changes to database</summary>
            _appDbContext.SaveChanges();

            /// <summary>return tokens and CLAIMS</summary>
            return Ok(new                                                         
            {
                Token = accessToken,
                RefreshToken = refreshToken,
                Claims = claims
            });

        }

        /// <summary>Post method for user registration</summary>
        /// <param name="model">user information for new instance in user database</param>
        /// <returns>OK() method if user is registered, otherwise BadRequest()</returns>
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
                _authService.Create(user, model.Password);            
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        /// <summary>Post method for user's personal dataupdate</summary>
        /// <param name="model">new name or surname for database update</param>
        /// <returns>OK() if user is updated, otherwise BadRequest()</returns>
        [HttpPost("/updateUser"), Authorize]
        public IActionResult UpdateUser([FromBody] UpdateUser model)                                   
        {
            /// <summary>Try to find user which is suppossed to be updated</summary>
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

        /// <summary>Post method for user's personal data update</summary>
        /// <param name="model">current password and new password for database update</param>
        /// <returns>OK() if user is updated, Unauthorized() in case user isn't verified, otherwise BadRequest()</returns>
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

        /// <summary>Get method for administrator</summary>
        /// <returns>Every user in Uuser database</returns>
        [HttpGet("/getUsers"), Authorize(Roles = "admin")]
        public List<UserBasicInfo> GetUsers()                                                                                     
        {
            var users = _appDbContext.Logins.Select(user => new UserBasicInfo() { 
                ID = user.ID, Email = user.Email, FirstName = user.FirstName, LastName = user.LastName, Role = user.Role
            }).ToList();
            return users;
        }

        /// <summary>Post method for deleting user</summary>
        /// <param name="userId">id of user which is suppossed to be deleted</param>
        /// <returns>OK() if user is found and deleted, BadRequest() in case user issn't found</returns>
        [HttpPost("/deleteUser"), Authorize(Roles = "admin")]
        public IActionResult DeleteUser([FromBody] int userId)                                 
        {
            var user = _appDbContext.Logins.FirstOrDefault(user => user.ID == userId);
            if (user == null)
            {
                return BadRequest("User not found");
            }
            _appDbContext.Logins.Remove(user);
            _appDbContext.SaveChanges();
            return Ok();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using bakalarska_praca.Models;
using bakalarska_praca.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace bakalarska_praca.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private AuthServices _authService;
        //private IMapper _mapper;
        public AuthController(AppDbContext appdbContext)        // IMapper mapper
        {
            _appDbContext = appdbContext;
            _authService = new AuthServices(appdbContext);
            //_mapper = mapper;

        }

        [AllowAnonymous]
        [HttpPost("/login")]
        public IActionResult Login([FromBody] Authenticate userModel) //
        {
            var user = _authService.Authenticate(userModel);     //funkcia na overenie ci existuje uzivatel v DB

            if (userModel.Email == "admin@flatlogic.com" && userModel.Password == "admin")           //zmenit na kontrolu hesla
            {
                string tokenString = _authService.GenerateToken();
                return Ok(new { Token = tokenString });
            }
            else
            {
                return Unauthorized();
            }
        }
        //[HttpPost("register")]
        //public IActionResult Register([FromBody] Register model)
        //{
        //    // map model to entity
        //    var user = _mapper.Map<User>(model);

        //    try
        //    {
        //        // create user
        //        _authService.Create(user, model.Password);
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        // return error message if there was an exception
        //        return BadRequest(new { message = ex.Message });
        //    }
        //}




        //        [HttpPost("login")]
        //        [ServiceFilter(typeof(ValidationFilterAttribute))]
        //        public async Task<IActionResult> Authenticate([FromBody] UserForAuthenticationDto
        //user)
        //        {
        //            if (!await _authManager.ValidateUser(user))
        //            {
        //                _logger.LogWarn($"{nameof(Authenticate)}: Authentication failed. Wrong
        //               user name or password.");
        //            return Unauthorized();
        //            }
        //            return Ok(new { Token = await _authManager.CreateToken() });
        //        }
    }
}

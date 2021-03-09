using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using bakalarska_praca.Models;
using bakalarska_praca.Services;
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
        private AuthServices authService;
        public AuthController(AppDbContext appdbContext)
        {
            _appDbContext = appdbContext;
            authService = new AuthServices(appdbContext);

        }

        [HttpPost("/login")]
        public IActionResult Login([FromBody] Login userModel) //
        {
            if (userModel == null)
            {
                return BadRequest("Invalid client request");
            }
            //var user = _appDbContext.Logins.Where(o => o.Email == userModel.Email).FirstOrDefault();
            
            //if (user != null && )

            if (userModel.Email == "johndoe" && userModel.Password == "def@123")           //zmenit na kontrolu z databaze
            {
                string tokenString = authService.GenerateToken();
                return Ok(new { Token = tokenString });
            }
            else
            {
                return Unauthorized();
            }
        }
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

using System;
using System.Linq;
using bakalarska_praca.Models;
using bakalarska_praca.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace bakalarska_praca.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private TokenServices _tokenService;

        public TokenController(AppDbContext appDbContext, IConfiguration config)
        {
            _appDbContext = appDbContext;
            _tokenService = new TokenServices(appDbContext, config);
        }
        [HttpPost]
        [Route("/refresh")]
        public IActionResult Refresh(Token tokenApiModel)               //metoda volana po vyprsani pristupoveho tokenu
        {
            if (tokenApiModel.AccessToken == null || tokenApiModel.RefreshToken == null)
            {
                return BadRequest("Invalid client request");
            }
            string accessToken = tokenApiModel.AccessToken;
            string refreshToken = tokenApiModel.RefreshToken;       
            var principal = _tokenService.GetPrincipalFromExpiredToken(accessToken);       //overenie zhody udajov z databaze a pristupoveho tokenu
            var username = principal.Identity.Name;
            var user = _appDbContext.Logins.SingleOrDefault(u => u.FirstName == username);                  
            if (user == null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
            {
                return BadRequest("Invalid client request");
            }
            var newAccessToken = _tokenService.GenerateAccessToken(principal.Claims);           //ak sa data zhoduju  a obnovovaci token nie je vyprsany => vygeneruju sa nove tokeny
            var newRefreshToken = _tokenService.GenerateRefreshToken();
            user.RefreshToken = newRefreshToken;
            _appDbContext.SaveChanges();
            return new ObjectResult(new
            {
                accessToken = newAccessToken,
                refreshToken = newRefreshToken
            });
        }
    }
}


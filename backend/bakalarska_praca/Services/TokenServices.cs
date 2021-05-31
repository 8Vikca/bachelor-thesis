using bakalarska_praca.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace bakalarska_praca.Services
{
    public class TokenServices
    {
        private readonly AppDbContext _appDbContext;
        private readonly string secret;
        private readonly string issuer;
        private readonly string audience;
        public TokenServices(AppDbContext appdbContext, IConfiguration config)   
        {
            _appDbContext = appdbContext;
            secret = config.GetValue<string>("ServiceConfiguration:JwtSettings:Secret");
            issuer = config.GetValue<string>("ServiceConfiguration:JwtSettings:Issuer");
            audience = config.GetValue<string>("ServiceConfiguration:JwtSettings:Audience");

        }

        /// <summary>Create new access token</summary>
        /// <param name="claims">claims for the method</param>
        /// <returns>new access token</returns>
        public string GenerateAccessToken(IEnumerable<Claim> claims)         
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);      

            var tokenOptions = new JwtSecurityToken(         
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(5),
                signingCredentials: signinCredentials
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            return tokenString;
        }

        /// <summary>Create new refresh token with random number</summary>
        /// <returns>new refresh token</returns>
        public string GenerateRefreshToken()     
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())   
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        /// <summary>Get principal from expired access token</summary>
        /// <param name="token">access token for the method</param>
        /// <returns>principal if token is valid, otherwise SecurityTokenException()</returns>
        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)     
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false, 
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret)),
                ValidateLifetime = false 
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                throw new SecurityTokenException("Invalid token");
            return principal;

        }
    }
}

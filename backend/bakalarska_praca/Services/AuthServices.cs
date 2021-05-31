using bakalarska_praca.Models;
using bakalarska_praca.Models.Auth;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bakalarska_praca.Services
{
    public class AuthServices
    {
        private readonly AppDbContext _appDbContext;
        public AuthServices(AppDbContext appdbContext)
        {
            _appDbContext = appdbContext;
        }

        /// <summary>Method for user authentication</summary>
        /// <param name="userModel">email and password for method</param>
        /// <returns>user object if authentication is successed</returns>
        public User Authenticate(Authenticate userModel)  
        {
            if (string.IsNullOrEmpty(userModel.Email) || string.IsNullOrEmpty(userModel.Password))
                return null;
            var user = _appDbContext.Logins.SingleOrDefault(x => x.Email == userModel.Email);
            if(user == null)
                return null;
            if (!VerifyPasswordHash(userModel.Password, user.PasswordHash, user.PasswordSalt))
                return null;
            return user;
        }

        /// <summary>Method for password verification</summary>
        /// <param name="userModel">email and password for method</param>
        /// <returns>true if verification is successed</returns>
        public bool PasswordVerification(UpdateUser userModel)        
        {
            if (string.IsNullOrEmpty(userModel.Email) || string.IsNullOrEmpty(userModel.CurrentPassword))
                return false;
            var user = _appDbContext.Logins.SingleOrDefault(x => x.Email == userModel.Email);
            if (user == null)
                return false;
            if (!VerifyPasswordHash(userModel.CurrentPassword, user.PasswordHash, user.PasswordSalt))
                return false;
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(userModel.NewPassword, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            _appDbContext.Logins.Update(user);
            _appDbContext.SaveChanges();
            return true;
        }

        /// <summary>Create user</summary>
        /// <param name="user">user object for method</param>
        /// <param name="password">password for method</param>
        /// <returns>user object if user is created and added to database</returns>
        public User Create(User user, string password)                 
        {
            if (string.IsNullOrWhiteSpace(password))
                return null;

            if (_appDbContext.Logins.Any(x => x.Email == user.Email))
                return null;

            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            _appDbContext.Logins.Add(user);
            _appDbContext.SaveChanges();

            return user;
        }

        /// <summary>Create hash</summary>
        /// <param name="password">password for method</param>
        /// <param name="passwordHash">password hash for method</param>
        /// <param name="passwordSalt">password salt for method</param>
        /// <returns>created hash and salt</returns>
        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)   
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        /// <summary>Verify hash</summary>
        /// <param name="password">password for method</param>
        /// <param name="storedHash">stored password hash for method</param>
        /// <param name="storedSalt">stored password salt for method</param>
        /// <returns>true if verification is successed</returns>
        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)   
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
            if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");
            if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");

            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }
            return true;
        }

        


    }
}

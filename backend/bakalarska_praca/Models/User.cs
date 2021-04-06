﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }        
        public byte[] PasswordSalt { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }

    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models
{
    public class Authenticate           //trieda pri autentizacii uzivatela
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        
    }
}

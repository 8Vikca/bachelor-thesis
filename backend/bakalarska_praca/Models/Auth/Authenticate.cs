using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models
{
    /// <summary>Class <c>Authenticate</c> models login verification </summary>
    public class Authenticate 
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        
    }
}

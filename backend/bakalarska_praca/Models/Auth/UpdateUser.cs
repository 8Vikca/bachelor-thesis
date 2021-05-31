using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models.Auth
{
    /// <summary>Class <c>UpdateUser</c> update user data or password</summary>
    public class UpdateUser 
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        
        [Required]
        public string Email { get; set; }

        public string CurrentPassword { get; set; }

        public string NewPassword { get; set; }
    }
}

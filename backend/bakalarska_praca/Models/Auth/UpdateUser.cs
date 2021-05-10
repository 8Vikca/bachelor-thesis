using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models.Auth
{
    public class UpdateUser
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string CurrentPassword { get; set; }

        public string NewPassword { get; set; }
    }
}

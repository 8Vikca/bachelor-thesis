using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models
{
    /// <summary>Class <c>Alert</c> models informations about alerts </summary>
    public class Alert  
    {
        public string Action { get; set; }
        public string Signature { get; set; }
        public string Category { get; set; }
        public double Severity { get; set; }

    }
}

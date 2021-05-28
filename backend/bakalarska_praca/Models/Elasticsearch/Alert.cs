using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models
{
    public class Alert          //pridavne vlastnosti json objektu
    {
        public string Action { get; set; }
        public string Signature { get; set; }
        public string Category { get; set; }
        public double Severity { get; set; }

    }
}

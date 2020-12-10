using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models
{
    public class Attack     //trieda na pracu s utokmi
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
    }
}

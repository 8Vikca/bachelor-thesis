using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models
{
    public class Timeline       //trieda na pracu s casovou osou
    {
        public DateTime  Timestamp { get; set; } = new DateTime();
        public int Value { get; set; }
        public string Option { get; set; }
    }
}

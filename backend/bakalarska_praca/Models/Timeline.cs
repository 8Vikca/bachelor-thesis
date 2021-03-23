using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models
{
    public class Timeline
    {
        public DateTime  Timestamp { get; set; } = new DateTime();
        public int Value { get; set; }
        public string LabelFormat { get; set; }
    }
}

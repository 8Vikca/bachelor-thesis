using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models
{
    public class Counter
    {
        public List<string> LabelSrc { get; set; } = new List<string>();
        public List<int> CounterSrc { get; set; } = new List<int>();
        public List<string> LabelCategory { get; set; } = new List<string>();
        public List<int> CounterCategory { get; set; } = new List<int>();

        public int AlertsTotal { get; set; } = 0;
        public int AlertsLow { get; set; } = 0;
        public int AlertsMedium{ get; set; } = 0;
        public int AlertsHigh { get; set; } = 0;
        public int AlertsCritical { get; set; } = 0;

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models.Dashboard
{
    public class ChartCounter       //trieda na pracu s grafmi
    {
        public List<string> LabelSrc { get; set; } = new List<string>();
        public List<int> CounterSrc { get; set; } = new List<int>();
        public List<string> LabelCategory { get; set; } = new List<string>();
        public List<int> CounterCategory { get; set; } = new List<int>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models.Dashboard
{
    /// <summary>Class <c>ChartCounter</c> models counters for charts data</summary>
    public class ChartCounter    
    {
        public List<string> LabelSrc { get; set; } = new List<string>();
        public List<int> CounterSrc { get; set; } = new List<int>();
        public List<string> LabelCategory { get; set; } = new List<string>();
        public List<int> CounterCategory { get; set; } = new List<int>();
    }
}

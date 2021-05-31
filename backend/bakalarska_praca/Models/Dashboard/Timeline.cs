using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models
{
    /// <summary>Class <c>Timeline</c> models data for timeline chart </summary>
    public class Timeline  
    {
        public DateTime  Timestamp { get; set; } = new DateTime();
        public int Value { get; set; }
        public string Option { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace bakalarska_praca.Models
{
    /// <summary>Class <c>Attack</c> models instance of Attacks Database </summary>
    public class Attack    
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int Severity { get; set; }
        public DateTime Timestamp { get; set; }
        public string Dest_ip { get; set; }
        public string Src_ip { get; set; }
        public string Proto { get; set; }
        public string Category { get; set; }
        public string SeverityCategory { get; set; }

    }
}

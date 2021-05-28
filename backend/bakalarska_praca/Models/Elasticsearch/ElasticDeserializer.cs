using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models
{
    public class ElasticDeserializer        //deserializovanie string na json vlastnosti
    {
        public string Id { get; set; }
        public string Event_type { get; set; }
        public string Proto { get; set; }
        public DateTime Timestamp { get; set; }
        public string Dest_ip { get; set; }
        public string Src_ip { get; set; }
        public string Dest_port { get; set; }
        public string Src_port { get; set; }
        public Alert Alert { get; set; } = new Alert();
    }
}

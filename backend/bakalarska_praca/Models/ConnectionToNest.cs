using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models
{
    public class ConnectionToNest
    {
        public ElasticClient Client { get; }
        public ConnectionToNest()
        {
            var settings = new ConnectionSettings(new Uri("http://localhost:9200"))
                .DefaultIndex("logs");

            this.Client = new ElasticClient(settings);
        }
    }
}

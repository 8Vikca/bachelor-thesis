using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;

namespace SearchAPI
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

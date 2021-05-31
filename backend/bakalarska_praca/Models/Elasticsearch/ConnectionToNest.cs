using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models
{
    /// <summary>Class <c>ConnectionToNest</c> models connection to Elasticsearch database </summary>
    public class ConnectionToNest       
    {
        public ElasticClient Client { get; }
        public ConnectionToNest()
        {
            var settings = new ConnectionSettings(new Uri("http://93.185.100.77:8172"))
                .DefaultIndex("filebeat-7.6.1-2021.05.11-000001");
            this.Client = new ElasticClient(settings);
        }
    }
}

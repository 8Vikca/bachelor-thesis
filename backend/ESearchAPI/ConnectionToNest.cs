using System;
using Nest;

namespace SearchAPI
{
    public class ConnectionToNest       //trieda na pristup ku klientovi NEST
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

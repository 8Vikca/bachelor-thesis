using System;
using System.Net.Http;
using bakalarska_praca.Controllers;
using bakalarska_praca.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace TimerTriggerFunction
{
    public class Function1
    {
        private readonly HttpClient _client;

        public Function1(HttpClient httpClient, ElasticSearchController controller)
        {
            this._client = httpClient;
        }
        [FunctionName("elasticTrigger")]
        public void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            //log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            var response = _client.GetAsync("https://localhost:44386/dataElastic");


        }
    }
}

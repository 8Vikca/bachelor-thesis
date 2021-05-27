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
        [FunctionName("elasticTrigger")]
        public void Run([TimerTrigger("0 */1 * * * *")]TimerInfo myTimer, ILogger log)
        {
            Console.WriteLine("GO");
            //var response = _client.GetAsync("https://localhost:44386/dataElastic");


        }
    }
}

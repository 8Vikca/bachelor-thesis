using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace RecalculateData
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task Run([TimerTrigger("0 */1 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");


            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://localhost:44386/dataElastic");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();


                Console.WriteLine(responseBody);
            }

        }
    }
}

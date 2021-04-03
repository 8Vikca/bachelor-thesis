using bakalarska_praca.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Services
{
    public class ElasticsearchServices
    {
        ConnectionToNest elasticSearchAPI;
        private readonly AppDbContext _appDbContext;
        public ElasticsearchServices(AppDbContext appdbContext)
        {
            _appDbContext = appdbContext;
            elasticSearchAPI = new ConnectionToNest();
        }

        [FunctionName("TimerTriggerElasticsearch")]
        public void Run([TimerTrigger("0 */5 * * * *")] TimerInfo myTimer, ILogger log)
        {
            if (myTimer.IsPastDue)
            {
                log.LogInformation("Timer is running late!");
            }
            log.LogInformation($"Function for Elasticsearch data executed at: {DateTime.Now}");

            var scanResults = elasticSearchAPI.Client.Search<Attack>(s => s        //vytiahnutie dat z databazy Elasticsearch
                            .From(0)
                            .Size(2000)
                            .Index("attack")
                            .Query(q => q.MatchAll()));


            var documents = scanResults.Documents.Select(f => f.Message).ToList();
            scanResults = null;
            if (documents.Count > 0)
            {
                foreach (var item in documents)         //vlozenie dat do lokalnej databazy
                {
                    var attack = new Attack();
                    attack.Message = item;
                    _appDbContext.Attacks.Add(attack);

                }
                _appDbContext.SaveChanges();
                var clearIndex = elasticSearchAPI.Client.Indices.Delete("attack");     //vymazanie dat ulozenych v lokalnej databaze z dovodu ich duplikacie
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using bakalarska_praca.Models;
using bakalarska_praca.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace bakalarska_praca.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [RequireHttps]
    public class ElasticSearchController : ControllerBase
    {
        ConnectionToNest _elasticSearchAPI;         //premenna na pristup ku klentovi NEST
        private readonly AppDbContext _appDbContext;
        List<Attack> listOfAttacks;
        public ElasticSearchController(AppDbContext appdbContext)
        {
            _appDbContext = appdbContext;
            _elasticSearchAPI = new ConnectionToNest();
            listOfAttacks = new List<Attack>();
        }


        [HttpGet("/dataElastic")]
        public IActionResult GetDataFromElastic()
        {
            var newestDate = _appDbContext.Attacks.OrderByDescending(a => a.Timestamp).FirstOrDefault().Timestamp;
            var scanResults = _elasticSearchAPI.Client.Search<StringMessage>(s => s        //vytiahnutie dat z databazy Elasticsearch
                            .From(0)
                            .Size(2000)
                            .Index("filebeat-7.6.1-2021.05.11-000001")
                            .Query(q => q.MatchAll()));
                            
            //.Query(q => q
            //                    .Bool(b => b
            //                        .Filter(bf => bf
            //                            .DateRange(r => r
            //                                .Field(f => f.Message.)
            //                                .GreaterThan(newestDate)
            //                            )
            //                        )
            //                    )
            //                )
            //            );

            var documents = scanResults.Hits.ToList();
            scanResults = null;
            if (documents.Count > 0)
            {
                foreach (var item in documents)         //vlozenie dat do lokalnej databazy
                {
                    //var deserializedJSON = new Message();
                    var deserializedJSON = JsonConvert.DeserializeObject<ElasticDeserializer>(item.Source.Message);
                    if (deserializedJSON.Timestamp <= newestDate)
                    {
                        continue;
                    }
                    var attack = new Attack();
                    switch (deserializedJSON.Alert.Signature)
                    {
                        case string a when a.Contains("SYN"):
                            attack.Message = deserializedJSON.Alert.Signature;
                            attack.Category = "SYN";
                            break;
                        case string a when a.Contains("ICMP"):
                            attack.Message = deserializedJSON.Alert.Signature;
                            attack.Category = "ICMP";
                            break;
                        case string a when a.Contains("SQL"):
                            attack.Message = deserializedJSON.Alert.Signature;
                            attack.Category = "SQL";
                            break;
                        case string a when a.Contains("CAM"):
                            attack.Message = deserializedJSON.Alert.Signature;
                            attack.Category = "CAM";
                            break;
                        case string a when a.Contains("UDP"):
                            attack.Message = deserializedJSON.Alert.Signature;
                            attack.Category = "UDP";
                            break;
                        default: continue;
                    }
                    attack.Proto = deserializedJSON.Proto;
                    attack.Src_ip = deserializedJSON.Src_ip;
                    attack.Dest_ip = deserializedJSON.Dest_ip;
                    attack.Timestamp = deserializedJSON.Timestamp;
                    attack.Severity = (int)deserializedJSON.Alert.Severity;
                    switch (deserializedJSON.Alert.Severity)
                    {
                        case var n when (n > 0.0 && n < 4.0):
                            attack.SeverityCategory = "low";
                            break;
                        case var n when (n >= 4.0 && n < 7.0):
                            attack.SeverityCategory = "medium";
                            break;
                        case var n when (n >= 7.0 && n < 9.0):
                            attack.SeverityCategory = "high";
                            break;
                        case var n when (n >= 9.0 && n <= 10.0):
                            attack.SeverityCategory = "critical";
                            break;
                        default:
                            attack.SeverityCategory = "undefined";
                            break;
                    }
                    listOfAttacks.Add(attack);
                    _appDbContext.Attacks.Add(attack);

                }
                if (listOfAttacks.Count > 0)
                {
                    _appDbContext.SaveChanges();
                }
                
                //var clearIndex = _elasticSearchAPI.Client.Indices.Delete("attack");     //vymazanie dat ulozenych v lokalnej databaze z dovodu ich duplikacie
            }
            return Ok();
        }
    }
}

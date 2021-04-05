using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using bakalarska_praca.Models;
using bakalarska_praca.Services;
using Microsoft.AspNetCore.Mvc;


namespace bakalarska_praca.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [RequireHttps]
    public class ElasticSearchController : ControllerBase
    {
        ConnectionToNest _elasticSearchAPI;         //premenna na pristup ku klentovi NEST
        private readonly AppDbContext _appDbContext;
        public ElasticSearchController(AppDbContext appdbContext, ConnectionToNest elasticSearchAPI)
        {
            _appDbContext = appdbContext;
            _elasticSearchAPI = elasticSearchAPI;
        }


        [HttpGet("/dataElastic")]
        public void GetDataFromElastic()
        {
            var scanResults = _elasticSearchAPI.Client.Search<Attack>(s => s        //vytiahnutie dat z databazy Elasticsearch
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
                var clearIndex = _elasticSearchAPI.Client.Indices.Delete("attack");     //vymazanie dat ulozenych v lokalnej databaze z dovodu ich duplikacie
            }
        }
    }
}

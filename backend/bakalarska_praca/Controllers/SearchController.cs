using System.Collections.Generic;
using System.Linq;
using bakalarska_praca.Models;
using Microsoft.AspNetCore.Mvc;
using SearchAPI;

namespace bakalarska_praca.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SearchController : ControllerBase      //controller na pracu s databazou
    {
        ConnectionToNest SearchAPI;         //premenna na pristup ku klentovi NEST
        private readonly AppDbContext _appDbContext;        //premenna na pracu s lokalnou databazou
        public SearchController(AppDbContext appdbContext)      //konštruktor
        {
            SearchAPI = new SearchAPI.ConnectionToNest();
            _appDbContext = appdbContext;

           
        }
        // GET: /search
        [HttpGet("/search")]
        public List<Attack> Get() 
        {
            //var scanResults = SearchAPI.Client.Search<Attack>(s => s        //vytiahnutie dat z databazy Elasticsearch
            //                .From(0)
            //                .Size(2000)
            //                .Index("attack")
            //                .Query(q => q.MatchAll()));


            //var documents = scanResults.Documents.Select(f => f.Message).ToList();
            //scanResults = null;
            //if (documents.Count > 0)        
            //{
            //    foreach (var item in documents)         //vlozenie dat do lokalnej databazy
            //    {
            //        var attack = new Attack();
            //        attack.Message = item;
            //        _appDbContext.Attacks.Add(attack);

            //    }
            //    _appDbContext.SaveChanges();
            //    var clearIndex = SearchAPI.Client.Indices.Delete("attack");     //vymazanie dat ulozenych v lokalnej databaze z dovodu ich duplikacie

            //}

            return _appDbContext.Attacks.OrderByDescending(o => o.Timestamp).ToList();    //vratenie vsetkych dat z lokalnej databazy vo forme listu objektov
        }
    }
}

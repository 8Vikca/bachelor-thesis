using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bakalarska_praca.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nest;

namespace bakalarska_praca.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        SearchAPI.ConnectionToNest SearchAPI;
        public SearchController()
        {
            SearchAPI = new SearchAPI.ConnectionToNest();
           
        }
        // GET: api/Search
        [HttpGet("/search")]
        public List<string> Get()
        {        
            var scanResults = SearchAPI.Client.Search<Attack>(s => s
                            .From(0)
                            .Size(2000)
                            .Index("filebeat-7.9.3-2020.11.08-000001")
                            .Query(q => q.MatchAll()));
            var documents = scanResults.Documents.Select(f => f.Message).ToList();
            return documents;
        }

        // GET: api/Search/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Search
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Search/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

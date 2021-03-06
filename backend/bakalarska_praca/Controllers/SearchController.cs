using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using bakalarska_praca.Models;
using Microsoft.AspNetCore.Mvc;
using SearchAPI;

namespace bakalarska_praca.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [RequireHttps]
    public class SearchController : ControllerBase      //controller na pracu s databazou
    {
        ConnectionToNest SearchAPI;         //premenna na pristup ku klentovi NEST
        private readonly AppDbContext _appDbContext;        //premenna na pracu s lokalnou databazou
        public SearchController(AppDbContext appdbContext)      //konštruktor
        {
            SearchAPI = new SearchAPI.ConnectionToNest();
            _appDbContext = appdbContext;


        }
        //[HttpGet,Authorize]


        [HttpGet("/dataElastic")]
        public void GetDataFromElastic() //List<Attack>
        {
            var scanResults = SearchAPI.Client.Search<Attack>(s => s        //vytiahnutie dat z databazy Elasticsearch
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
                var clearIndex = SearchAPI.Client.Indices.Delete("attack");     //vymazanie dat ulozenych v lokalnej databaze z dovodu ich duplikacie
            }
        }

        [HttpGet("/allData")]
        public List<Attack> GetAllData()
        {
            var selectedData = _appDbContext.Attacks.OrderByDescending(o => o.Timestamp).ToList();
            return selectedData;
        }


        [HttpGet("/timelineData")]
        public List<Attack> GetTimelineData(DateTime startDate, DateTime endDate)
        {
            var selectedData = _appDbContext.Attacks.Where(o => o.Timestamp >= startDate && o.Timestamp <= endDate)
                                .OrderByDescending(o => o.Timestamp).ToList();
            return selectedData;
        }

        [HttpGet("/recentData")]
        public List<Attack> GetRecentData(DateTime startDate, DateTime endDate)
        {
            var selectedData = _appDbContext.Attacks.Where(o => o.Timestamp >= startDate && o.Timestamp <= endDate)
                                .OrderByDescending(o => o.Timestamp)
                                .Take(10).ToList();
            return selectedData;
        }

        [HttpGet("/severityData")]
        public List<Attack> GetSeverityData(DateTime startDate, DateTime endDate)
        {
            var selectedData = _appDbContext.Attacks.Where(o => o.Timestamp >= startDate && o.Timestamp <= endDate)
                .OrderByDescending(o => o.Severity)
                                .Take(10).ToList();
            return selectedData;
        }

        [HttpGet("/graphData")]
        public List<Attack> GetAllGraphData(DateTime startDate, DateTime endDate)
        {
            var selectedData = _appDbContext.Attacks.Where(o => o.Timestamp >= startDate && o.Timestamp <= endDate)
                .OrderBy(o => o.Src_ip).ToList();
            return selectedData;
        }

        [HttpGet("/counter")]
        public Counter GetCounter(DateTime startDate, DateTime endDate)
        {
            var counter = new Counter();
            var selectedData = _appDbContext.Attacks.Where(o => o.Timestamp >= startDate && o.Timestamp <= endDate)
                .ToList();
            var srcDictionary = new Dictionary<string, int>();
            var categoryDictionary = new Dictionary<string, int>();
            if (selectedData.Count == 0)
            {
                return counter;
            }
            for (int i = 0; i < selectedData.Count; i++)        //pocitanie SRC IP a Category
            {
                if (!srcDictionary.ContainsKey(selectedData[i].Src_ip))
                {
                    srcDictionary.Add(selectedData[i].Src_ip, 1);
                }
                else
                {
                    srcDictionary[selectedData[i].Src_ip] += 1;
                }

                switch (selectedData[i].SeverityCategory)
                {
                    case "low":
                        counter.AlertsLow += 1;
                        break;
                    case "medium":
                        counter.AlertsMedium += 1;
                        break;
                    case "high":
                        counter.AlertsHigh += 1;
                        break;
                    case "critical":
                        counter.AlertsCritical += 1;
                        break;

                    default:
                        break;
                }
                if (!categoryDictionary.ContainsKey(selectedData[i].Category))
                {
                    categoryDictionary.Add(selectedData[i].Category, 1);
                }
                else
                {
                    categoryDictionary[selectedData[i].Category] += 1;
                }
            }
            counter.AlertsTotal = counter.AlertsLow + counter.AlertsMedium + counter.AlertsHigh + counter.AlertsCritical;
            srcDictionary = srcDictionary.OrderByDescending(o => o.Value).Take(5).ToDictionary(o=> o.Key, o=> o.Value);
            categoryDictionary = categoryDictionary.OrderByDescending(o => o.Value).Take(5).ToDictionary(o => o.Key, o => o.Value);
            foreach (var item in srcDictionary)
            {
                counter.LabelSrc.Add(item.Key);
                counter.CounterSrc.Add(item.Value);
            }
            foreach (var item in categoryDictionary)
            {
                counter.LabelCategory.Add(item.Key);
                counter.CounterCategory.Add(item.Value);
            }
            return counter;
        }
    }
}

﻿using System;
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
    public class SearchController : ControllerBase      //controller na pracu s databazou
    {
        ConnectionToNest SearchAPI;         //premenna na pristup ku klentovi NEST
        private readonly AppDbContext _appDbContext;        //premenna na pracu s lokalnou databazou
        public SearchController(AppDbContext appdbContext)      //konštruktor
        {
            SearchAPI = new SearchAPI.ConnectionToNest();
            _appDbContext = appdbContext;


        }

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


        // GET: /search
        [HttpGet("/allData")]
        public List<Attack> GetAllData()
        {


            return _appDbContext.Attacks.OrderByDescending(o => o.Timestamp).ToList();    //vratenie vsetkych dat z lokalnej databazy vo forme listu objektov
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bakalarska_praca.Models;
using bakalarska_praca.Models.Dashboard;
using bakalarska_praca.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bakalarska_praca.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [RequireHttps]
    [Authorize]
    public class DashboardController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public DashboardServices dashboardService;
        public DashboardController(AppDbContext appdbContext)
        {
            dashboardService = new DashboardServices(appdbContext);
            _appDbContext = appdbContext;
        }

        [HttpGet("/recentData")]
        public List<Attack> GetRecentData(DateTime startDate, DateTime endDate)                         //get metoda na vratenie najnovsich 10 dat
        {

            var selectedData = _appDbContext.Attacks.Where(o => o.Timestamp >= startDate && o.Timestamp <= endDate)
                             .OrderByDescending(o => o.Timestamp)
                             .Take(10).ToList();
            return selectedData;
        }

        [HttpGet("/severityData")]
        public List<Attack> GetSeverityData(DateTime startDate, DateTime endDate)           //get metoda na vratenie najzavaznejsich 10 dat
        {
            var selectedData = _appDbContext.Attacks.Where(o => o.Timestamp >= startDate && o.Timestamp <= endDate)
                .OrderByDescending(o => o.Severity)
                                .Take(10).ToList();
            return selectedData;
        }

        [HttpGet("/counter")]
        public Counter GetCounter(DateTime startDate, DateTime endDate)             //get metoda na vratenie pocitadla
        {
            var counter = new Counter();
            counter = dashboardService.LoadCounters(startDate, endDate);
            return counter;
        }

        [HttpGet("/chartData")]
        public ChartCounter GetChartData(DateTime startDate, DateTime endDate)          //get metoda na vratenie dat pre grafy
        {
            var counter = new ChartCounter();
            counter = dashboardService.LoadChartCounter(startDate, endDate);
            return counter;
        }

        [HttpGet("/timelineData")]
        public List<Timeline> GetTimelineData(DateTime startDate, DateTime endDate)         //get metoda na vratenie dat pre casovu os
        {
            var selectedData = _appDbContext.Attacks.Where(o => o.Timestamp >= startDate && o.Timestamp <= endDate).OrderByDescending(o => o.Timestamp).ToList();
            var variety = endDate.Date.Subtract(startDate.Date);
            var timelineData = dashboardService.LoadTimelineData(variety, selectedData);
            return timelineData;
        }
    }
}

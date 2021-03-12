using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bakalarska_praca.Models;
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
        //[HttpGet,Authorize]

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

        [HttpGet("/counter")]
        public Counter GetCounter(DateTime startDate, DateTime endDate)
        {
            var counter = new Counter();
            counter = dashboardService.LoadCounters(startDate, endDate);
            return counter;
        }
    }
}

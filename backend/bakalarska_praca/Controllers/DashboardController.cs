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
    /// <summary>Controller <c>DashboardController</c> works with methods from section Dashboard</summary>
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

        /// <summary>Get method for most recent data</summary>
        /// <param name="startDate">start date for the get method.</param>
        /// <param name="endDate">end date for the get method.</param>
        /// <returns>filtered data by dates and ordered by timestamp descending</returns>
        [HttpGet("/recentData")]
        public List<Attack> GetRecentData(DateTime startDate, DateTime endDate)                        
        {

            var selectedData = _appDbContext.Attacks.Where(o => o.Timestamp >= startDate && o.Timestamp <= endDate)
                             .OrderByDescending(o => o.Timestamp)
                             .Take(10).ToList();
            return selectedData;
        }

        /// <summary>Get method for most severity data</summary>
        /// <param name="startDate">start date for the get method.</param>
        /// <param name="endDate">end date for the get method.</param>
        /// <returns>filtered data by dates and ordered by severity descending in given date range</returns>
        [HttpGet("/severityData")]
        public List<Attack> GetSeverityData(DateTime startDate, DateTime endDate)         
        {
            var selectedData = _appDbContext.Attacks.Where(o => o.Timestamp >= startDate && o.Timestamp <= endDate)
                .OrderByDescending(o => o.Severity)
                                .Take(10).ToList();
            return selectedData;
        }

        /// <summary>Get method for counters</summary>
        /// <param name="startDate">start date for the get method.</param>
        /// <param name="endDate">end date for the get method.</param>
        /// <returns>number of incidents of every severity category in given date range</returns>
        [HttpGet("/counter")]
        public Counter GetCounter(DateTime startDate, DateTime endDate)             
        {
            var counter = new Counter();
            counter = dashboardService.LoadCounters(startDate, endDate);
            return counter;
        }

        /// <summary>Get method for charts data</summary>
        /// <param name="startDate">start date for the get method.</param>
        /// <param name="endDate">end date for the get method.</param>
        /// <returns>numbers of most popular category and  numbers of most source IPs in given date range</returns>
        [HttpGet("/chartData")]
        public ChartCounter GetChartData(DateTime startDate, DateTime endDate)        
        {
            var counter = new ChartCounter();
            counter = dashboardService.LoadChartCounter(startDate, endDate);
            return counter;
        }

        /// <summary>Get method for timeline data</summary>
        /// <param name="startDate">start date for the get method.</param>
        /// <param name="endDate">end date for the get method.</param>
        /// <returns>number of incidents grouped by timestamp in given date range</returns>
        [HttpGet("/timelineData")]
        public List<Timeline> GetTimelineData(DateTime startDate, DateTime endDate)        
        {
            var selectedData = _appDbContext.Attacks.Where(o => o.Timestamp >= startDate && o.Timestamp <= endDate).OrderByDescending(o => o.Timestamp).ToList();
            var variety = endDate.Date.Subtract(startDate.Date);
            var timelineData = dashboardService.LoadTimelineData(variety, selectedData);
            return timelineData;
        }
    }
}

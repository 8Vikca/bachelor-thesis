using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bakalarska_praca.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bakalarska_praca.Controllers
{
    /// <summary>Controller <c>TableController</c> works with methods from section Investigation</summary>
    [Route("[controller]")]
    [ApiController]
    [RequireHttps]
    public class TableController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public TableController(AppDbContext appdbContext)
        {
            _appDbContext = appdbContext;
        }

        /// <summary>Get method for all data</summary>
        /// <returns>all data ordered by timestamp descending</returns>
        [HttpGet("/allData"), Authorize]
        public List<Attack> GetAllData()          
        {
            var selectedData = _appDbContext.Attacks.OrderByDescending(o => o.Timestamp).Take(1000).ToList();
            return selectedData;
        }

        /// <summary>Get method for filtered data</summary>
        /// <param name="startDate">start date for the get method.</param>
        /// <param name="endDate">end date for the get method.</param>
        /// <param name="filter">array of filters to apply</param>
        /// <returns>filtered data by dates and filters and ordered by timestamp descending</returns>
        [HttpGet("/filteredData"), Authorize] 
        public List<Attack> GetFilteredData(DateTime startDate, DateTime endDate, [FromQuery] string[] filter)  
        {
            /// <summary>check if array isn't empty</summary>
            /// <returns>filtered data by dates and ordered by timestamp descending</returns>
            if (filter.Length == 0)         
            {
                var allData = _appDbContext.Attacks.Where(o => o.Timestamp >= startDate && o.Timestamp <= endDate).OrderByDescending(o => o.Timestamp).Take(1000).ToList();
                return allData;
            }

            /// <summary>divide string into metakey and value</summary>
            List<Filter> filters = new List<Filter>();
            foreach (var item in filter) 
            {
                List<string> splitItems = item.Split(' ').ToList();
                filters.Add(new Filter { Parameter = splitItems[0], Value = splitItems[2] });
            }
            var selectedData = _appDbContext.Attacks.Where(o => o.Timestamp >= startDate && o.Timestamp <= endDate).OrderByDescending(o => o.Timestamp).ToList();

            /// <summary>apply filters</summary>
            foreach (var item in filters)                     
            {
                item.Parameter = item.Parameter.ToUpper();
                item.Value = item.Value.ToUpper();
                try
                {
                    switch (item.Parameter)
                    {
                        case string a when a.Contains("CATEGORY"):
                            selectedData = selectedData.Where(o => o.Category == item.Value).ToList();
                            break;
                        case string a when a.Contains("SRC_IP"):
                            selectedData = selectedData.Where(o => o.Src_ip == item.Value).ToList();
                            break;
                        case string a when a.Contains("DEST_IP"):
                            selectedData = selectedData.Where(o => o.Dest_ip == item.Value).ToList();
                            break;
                        case string a when a.Contains("PROTO"):
                            selectedData = selectedData.Where(o => o.Proto == item.Value).ToList();
                            break;
                        case string a when a.Contains("SEVERITY"):
                            selectedData = selectedData.Where(o => o.Severity == int.Parse(item.Value)).ToList();
                            break;
                    }
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }

            }
            selectedData = selectedData.Take(1000).ToList();
            return selectedData;
        }
    }
}

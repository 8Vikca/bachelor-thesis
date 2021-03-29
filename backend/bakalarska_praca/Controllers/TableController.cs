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

        [HttpGet("/allData"), Authorize]
        public List<Attack> GetAllData()
        {
            var selectedData = _appDbContext.Attacks.OrderByDescending(o => o.Timestamp).Take(100).ToList();
            return selectedData;
        }
        [HttpGet("/filteredData")] //Authorize
        public List<Attack> GetFilteredData([FromQuery]string[] filter)   //[FromBody] string[] filters
        {
            List<Filter> filters = new List<Filter>();
            foreach (var item in filter)
            {
                string[] splitItems=item.Split(' ');
                filters.Add(new Filter { Parameter = splitItems[0], Value = splitItems[2]});
            }
            var selectedData = _appDbContext.Attacks.OrderByDescending(o => o.Timestamp).ToList();

            foreach (var item in filters)
            {
                try
                {
                    switch (item.Parameter)
                    {
                        case string a when a.Contains("Category"):
                            selectedData = selectedData.Where(o => o.Category == item.Value).ToList();
                            break;
                        case string a when a.Contains("Src_ip"):
                            selectedData = selectedData.Where(o => o.Src_ip == item.Value).ToList();
                            break;
                        case string a when a.Contains("Dest_ip"):
                            selectedData = selectedData.Where(o => o.Dest_ip == item.Value).ToList();
                            break;
                        case string a when a.Contains("Proto"):
                            selectedData = selectedData.Where(o => o.Proto == item.Value).ToList();
                            break;
                        case string a when a.Contains("Severity"):
                            selectedData = selectedData.Where(o => o.Severity == int.Parse(item.Value)).ToList();
                            break;


                        default:
                            break;
                    }
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }
                
            }
            
            return selectedData;
        }
    }
}

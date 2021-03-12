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

        [HttpGet("/allData")] //Authorize
        public List<Attack> GetAllData()
        {
            var selectedData = _appDbContext.Attacks.OrderByDescending(o => o.Timestamp).ToList();
            return selectedData;
        }
    }
}

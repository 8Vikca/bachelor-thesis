using bakalarska_praca.Models;
using SearchAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Services
{
    public class DashboardServices
    {
        
        private readonly AppDbContext _appDbContext;
        public DashboardServices(AppDbContext appdbContext)
        {
            _appDbContext = appdbContext;
        }

        public Counter LoadCounters(DateTime startDate, DateTime endDate)
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
            srcDictionary = srcDictionary.OrderByDescending(o => o.Value).Take(5).ToDictionary(o => o.Key, o => o.Value);
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

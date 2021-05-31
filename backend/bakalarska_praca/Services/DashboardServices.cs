using bakalarska_praca.Models;
using bakalarska_praca.Models.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;

namespace bakalarska_praca.Services
{
    public class DashboardServices
    {

        private readonly AppDbContext _appDbContext;      
        public DashboardServices(AppDbContext appdbContext)
        {
            _appDbContext = appdbContext;
        }

        /// <summary>Counter of incidents of severity categories</summary>
        /// <param name="startDate">start date for the method.</param>
        /// <param name="endDate">end date for the method.</param>
        /// <returns>counter</returns>
        public Counter LoadCounters(DateTime startDate, DateTime endDate) 
        {
            var counter = new Counter();
            var selectedData = _appDbContext.Attacks.Where(o => o.Timestamp >= startDate && o.Timestamp <= endDate)
                .ToList();
            if (selectedData.Count == 0)
            {
                return counter;
            }
            for (int i = 0; i < selectedData.Count; i++)        
            {
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
            }
            counter.AlertsTotal = counter.AlertsLow + counter.AlertsMedium + counter.AlertsHigh + counter.AlertsCritical;
            return counter;
        }

        /// <summary>TOP 5 most used severity categories and source IPs</summary>
        /// <param name="startDate">start date for the method.</param>
        /// <param name="endDate">end date for the method.</param>
        /// <returns>counter</returns>
        public ChartCounter LoadChartCounter(DateTime startDate, DateTime endDate)   
        {
            var counter = new ChartCounter();
            var selectedData = _appDbContext.Attacks.Where(o => o.Timestamp >= startDate && o.Timestamp <= endDate)
               .ToList();
            if (selectedData.Count == 0)
            {
                return counter;
            }
            var srcDictionary = new Dictionary<string, int>();
            var categoryDictionary = new Dictionary<string, int>();
           
            for (int i = 0; i < selectedData.Count; i++)        
            {
                if (!srcDictionary.ContainsKey(selectedData[i].Src_ip))     
                {
                    srcDictionary.Add(selectedData[i].Src_ip, 1);
                }
                else
                {
                    srcDictionary[selectedData[i].Src_ip] += 1;
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

        /// <summary>Counter of incidents by timestamp</summary>
        /// <param name="variety">variety between startDate and endDate</param>
        /// <param name="selectedData">data from date range</param>
        /// <returns>counter</returns>
        public List<Timeline> LoadTimelineData(TimeSpan variety, List<Attack> selectedData)         //vypocet podla casu
        {
            var timelineData = new List<Timeline>();
            string option;
            var timelineDictionary = this.fillDictionary(selectedData, variety, out option);        
            foreach (var item in timelineDictionary)
            {
                timelineData.Add(new Timeline { Timestamp = item.Key, Value = item.Value, Option = option });
            }
            return timelineData;
        }

        /// <summary>Method for filling Dictionary with counters</summary>
        /// <param name="selectedData">email and password for method</param>
        /// <param name="variety">variety between startDate and endDate</param>
        /// <param name="option">incidents are grouped by hours or days</param>
        /// <returns>data grouped by choosed option</returns>
        public Dictionary<DateTime, int> fillDictionary(List<Attack> selectedData, TimeSpan variety, out string option)   
        {
            option = "";
            var timelineDictionary = new Dictionary<DateTime, int>();
            for (int i = 0; i < selectedData.Count; i++)
            {
                switch(variety.TotalDays)
                {
                    case double number when number <= 1:                                        //zvoleny datum je mensi ako 24 hodin
                        var temp = selectedData[i].Timestamp.Hour;
                        selectedData[i].Timestamp = selectedData[i].Timestamp.Date;
                        selectedData[i].Timestamp = selectedData[i].Timestamp.AddHours(temp);
                        option = "hours";
                        break;
                    case double number when number >1:                                         //zvoleny datum je vacsi ako 24 hodin
                        selectedData[i].Timestamp = selectedData[i].Timestamp.Date;
                        option = "days";
                        break;
                }
                if (!timelineDictionary.ContainsKey(selectedData[i].Timestamp))
                {
                    timelineDictionary.Add(selectedData[i].Timestamp, 1);
                }
                else
                {
                    timelineDictionary[selectedData[i].Timestamp] += 1;
                }
            }
            return timelineDictionary;
        }
    }
}

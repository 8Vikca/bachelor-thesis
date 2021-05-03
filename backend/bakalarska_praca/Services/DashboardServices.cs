using bakalarska_praca.Models;
using bakalarska_praca.Models.Dashboard;
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
            if (selectedData.Count == 0)
            {
                return counter;
            }
            var srcDictionary = new Dictionary<string, int>();
            var categoryDictionary = new Dictionary<string, int>();
            
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
        public List<Timeline> LoadTimelineData(TimeSpan variety, List<Attack> selectedData)
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
        public Dictionary<DateTime, int> fillDictionary(List<Attack> selectedData, TimeSpan variety, out string option)
        {
            option = "";
            var timelineDictionary = new Dictionary<DateTime, int>();
            for (int i = 0; i < selectedData.Count; i++)
            {
                switch(variety.TotalDays)
                {
                    case double number when number <= 1:
                        selectedData[i].Timestamp = selectedData[i].Timestamp.AddMinutes(-selectedData[i].Timestamp.Minute).AddSeconds(-selectedData[i].Timestamp.Second)
                            .AddMilliseconds(-selectedData[i].Timestamp.Millisecond);
                        option = "hours";
                        break;
                    case double number when number >1 :   //&& number <=31
                        selectedData[i].Timestamp = selectedData[i].Timestamp.AddHours(-selectedData[i].Timestamp.Hour).AddMinutes(-selectedData[i].Timestamp.Minute)
                            .AddSeconds(-selectedData[i].Timestamp.Second).AddMilliseconds(-selectedData[i].Timestamp.Millisecond);
                        option = "days";
                        break;
                    //case double number when (number > 31 && number <= 365):
                    //    selectedData[i].Timestamp = selectedData[i].Timestamp.AddDays(-selectedData[i].Timestamp.Day).AddHours(-selectedData[i].Timestamp.Hour)
                    //        .AddMinutes(-selectedData[i].Timestamp.Minute).AddSeconds(-selectedData[i].Timestamp.Second).AddMilliseconds(-selectedData[i].Timestamp.Millisecond);
                    //    break;
                    //case double number when (number > 365):
                    //    selectedData[i].Timestamp = selectedData[i].Timestamp.AddMonths(-selectedData[i].Timestamp.Month).AddDays(-selectedData[i].Timestamp.Day)
                    //        .AddHours(-selectedData[i].Timestamp.Hour).AddMinutes(-selectedData[i].Timestamp.Minute).AddSeconds(-selectedData[i].Timestamp.Second)
                    //        .AddMilliseconds(-selectedData[i].Timestamp.Millisecond);
                    //    break;
                }
                //if (variety.TotalDays <= 1) //data s casom pre max 2 dni
                //{
                //    selectedData[i].Timestamp = selectedData[i].Timestamp.AddMinutes(-selectedData[i].Timestamp.Minute).AddSeconds(-selectedData[i].Timestamp.Second).AddMilliseconds(-selectedData[i].Timestamp.Millisecond);
                //}
                //else if (variety.TotalDays <= 31)
                //{
                //    selectedData[i].Timestamp = selectedData[i].Timestamp.AddHours(-selectedData[i].Timestamp.Hour).AddMinutes(-selectedData[i].Timestamp.Minute).AddSeconds(-selectedData[i].Timestamp.Second).AddMilliseconds(-selectedData[i].Timestamp.Millisecond);
                //}
                //else
                //{

                //}
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

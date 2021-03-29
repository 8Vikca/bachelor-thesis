import { Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import {
  ApexAxisChartSeries,
  ApexChart,
  ApexTitleSubtitle,
  ApexDataLabels,
  ApexFill,
  ApexMarkers,
  ApexYAxis,
  ApexXAxis,
  ApexTooltip
} from "ng-apexcharts";
import { Attack, Timeline } from '../../models';
import { dataSeries } from "./data-series";

@Component({
  selector: 'app-timeline-chart',
  templateUrl: './timeline-chart.component.html',
  styleUrls: ['./timeline-chart.component.scss']
})
export class TimelineChartComponent implements OnChanges{
  public series: ApexAxisChartSeries;
  public chart: ApexChart;
  public dataLabels: ApexDataLabels;
  public markers: ApexMarkers;
  public title: ApexTitleSubtitle;
  public fill: ApexFill;
  public yaxis: ApexYAxis;
  public xaxis: ApexXAxis;
  public tooltip: ApexTooltip;

  @Input() timelineData: Timeline[] = [];

  constructor() {
    this.initChartData();
  }
  ngOnChanges(): void {
    this.initChartData();
  }

  public initChartData(): void {
    let dates = [];
     this.timelineData.forEach(element => {
      dates.push([element.timestamp, element.value])  
    }); 
    debugger
    this.series = [
      {
        name: "Incidents",
        data: dates,
        color: "#a89776"
      }
    ];
    this.chart = {
      type: "bar",
      stacked: false,
      height: 350,
      zoom: {
        type: "x",
        enabled: true,
        autoScaleYaxis: true,
      },
      toolbar: {
        autoSelected: "pan",
        tools: {
          download: false,
        }
      }
    };
    this.dataLabels = {
      enabled: false
    };
    this.markers = {
      size: 0
    };
    this.title = {
      text: "",
      align: "left"
    };
    // this.fill = {
    //   type: "gradient",
    //   gradient: {
    //     shadeIntensity: 1,
    //     inverseColors: false,
    //     opacityFrom: 0.5,
    //     opacityTo: 0,
    //     stops: [0, 90, 100]
    //   }
    // };
    this.yaxis = {
      // labels: {
      //   formatter: function(val) {
      //     return (val).toFixed(0);
      //   }
      // },
      title: {
        text: "Total"
      }
    };
    this.xaxis = {
      type: "datetime",
      labels: {
      datetimeFormatter: {
        year: 'yyyy',
        month: 'MMM \'yy',
        day: 'dd MMM',
        hour: 'HH:mm'
      }
    }
    };
    this.tooltip = {
      shared: false,
      x: {
        format: "MMM dd, HH:mm",
      },
      y: {
        formatter: function(val) {
          return (val).toFixed(0);
        }
      }
    };
  }
}

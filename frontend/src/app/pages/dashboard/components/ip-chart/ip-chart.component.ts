import { Component, Input, OnChanges, SimpleChanges, ViewChild } from "@angular/core";

import {
  ApexNonAxisChartSeries,
  ApexResponsive,
  ApexChart,
  ChartComponent
} from "ng-apexcharts";
import { Attack, Counter } from "../../models";

export type ChartOptions = {
  series: ApexNonAxisChartSeries;
  chart: ApexChart;
  responsive: ApexResponsive[];
  labels: any;
  colors: string[];
};

@Component({
  selector: 'app-ip-chart',
  templateUrl: './ip-chart.component.html',
  styleUrls: ['./ip-chart.component.scss']
})
export class IpChartComponent implements OnChanges{
  @ViewChild("chart") chart: ChartComponent;
  @Input() ipChartSeries: Counter = {};
  public chartOptions: Partial<ChartOptions>;

  constructor() {
    this.initializeChart();
  }
  ngOnChanges(): void {
    this.initializeChart();
  }
    
  initializeChart() {   
    this.chartOptions = {
      series: this.ipChartSeries.counterSrc,
      chart: {
        width: 380,
        type: "pie"
      },
      labels: this.ipChartSeries.labelSrc,
      responsive: [
        {
          breakpoint: 480,
          options: {
            chart: {
              width: 200
            },
            legend: {
              position: "right"
            }
          }
        }
      ],
      colors:['#85603f', '#9e7540', '#bd9354', '#bfb051', '#e3d18a']
    };
  
  }
}
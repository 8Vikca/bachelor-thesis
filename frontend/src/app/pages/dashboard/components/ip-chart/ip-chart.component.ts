import { Component, Input, OnChanges, SimpleChanges, ViewChild } from "@angular/core";

import {
  ApexNonAxisChartSeries,
  ApexResponsive,
  ApexChart,
  ChartComponent
} from "ng-apexcharts";
import { colors } from "src/app/consts";
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
  @Input() ipGraphData: Attack[] = [];
  @Input() ipGraphSeries: Counter = {
    counterSrc : [],
    labelSrc : [],
    alertsCritical: null, alertsHigh: null, alertsLow: null, alertsMedium: null, alertsTotal: null,
  };
  public chartOptions: Partial<ChartOptions>;
  dataLabel: string[] = [];
  dataCounter: number[] = [];

  constructor() {
    this.initializeChart();
  }
  ngOnChanges(): void {
    this.initializeChart();
  }
    
  initializeChart() {   
    this.chartOptions = {
      series: this.ipGraphSeries.counterSrc,
      chart: {
        width: 380,
        type: "pie"
      },
      labels: this.ipGraphSeries.labelSrc,
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
      colors:['#F44336', '#E91E63', '#9C27B0', '#798DFE', '#9C27D0', '#9D22D0','#9C27D0','#9C27D0','#9C27D0']
    };
  
  }
}
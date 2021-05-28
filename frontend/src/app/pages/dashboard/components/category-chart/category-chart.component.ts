import { Component, Input, OnChanges, ViewChild } from "@angular/core";
import { ChartCounter } from "../../models";
import {
  ApexNonAxisChartSeries,
  ApexResponsive,
  ApexChart,
  ChartComponent
} from "ng-apexcharts";

export type ChartOptions = {
  series: ApexNonAxisChartSeries;
  chart: ApexChart;
  responsive: ApexResponsive[];
  labels: any;
  colors: string[];
};

@Component({
  selector: 'app-category-chart',
  templateUrl: './category-chart.component.html',
  styleUrls: ['./category-chart.component.scss']
})
export class CategoryChartComponent implements OnChanges{
  @ViewChild("chart") chart: ChartComponent;
  public chartOptions: Partial<ChartOptions>;
  @Input() categoryChartSeries: ChartCounter = {
    counterCategory : [], labelCategory : []
  };

  constructor() {
    this.initializeChart();
  }
  ngOnChanges(): void {
    this.initializeChart();
  }
    
  initializeChart() {   
    this.chartOptions = {
      series: this.categoryChartSeries.counterCategory,
      chart: {
        width: 380,
        height: 214.69,
        type: "pie"
      },
      labels: this.categoryChartSeries.labelCategory,
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
      colors:['#52524e', '#9a9b94', '#d4d6c8', '#dfdfdf', '#e9e9e5']
    };
  }
}
import { Component, Input, OnChanges, SimpleChanges, ViewChild } from "@angular/core";
import { colors } from 'src/app/consts/colors';
import { Attack, Counter } from "../../models";
import {
  ApexNonAxisChartSeries,
  ApexResponsive,
  ApexChart,
  ChartComponent
} from "ng-apexcharts";

type ApexXAxis = {
  type?: "category" | "datetime" | "numeric";
  categories?: any;
  labels?: {
    style?: {
      colors?: string | string[];
      fontSize?: string;
    };
  };
};

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
  @Input() ipGraphSeries: Counter = {};

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
      colors:['#b88c8c', '#ddadad', '#d6c7c7', '#9fb9bf', '#aec8ce']
    };
  
  }
}
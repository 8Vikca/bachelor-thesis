import { Component, Input, OnChanges, OnInit, SimpleChanges, ViewChild } from "@angular/core";
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
export class CategoryChartComponent implements OnInit, OnChanges{
  @ViewChild("chart") chart: ChartComponent;
  public chartOptions: Partial<ChartOptions>;
  @Input() categoryChartSeries: Counter = {};

  constructor() {
    this.initializeChart();
  }
  ngOnInit(): void {
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
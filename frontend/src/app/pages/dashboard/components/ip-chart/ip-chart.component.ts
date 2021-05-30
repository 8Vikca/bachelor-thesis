import { Component, Input, OnChanges, ViewChild } from "@angular/core";
import { ChartComponent} from "ng-apexcharts";
import { ChartOptions } from "..";
import { ChartCounter } from "../../models";

@Component({
  selector: 'app-ip-chart',
  templateUrl: './ip-chart.component.html',
  styleUrls: ['./ip-chart.component.scss']
})
export class IpChartComponent implements OnChanges{
  @ViewChild("chart") chart: ChartComponent;
  @Input() ipChartSeries: ChartCounter = {counterSrc: null, labelSrc:  null};
  public chartOptions: Partial<ChartOptions>;

  constructor() {
    this.initializeChart();
  }
 
  ngOnChanges(): void {
    this.initializeChart();
  }
    
  initializeChart() {         //nastavenia grafu
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
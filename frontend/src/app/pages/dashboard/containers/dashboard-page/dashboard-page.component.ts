import { Component } from '@angular/core';
import { DashboardService } from '../../services';
import {
  Attack,
  ChartCounter,
  Counter,
  Timeline,
} from '../../models';
import { HttpParams } from '@angular/common/http';
import { AircalResponse } from 'ngx-aircal';
import { MatDialog } from '@angular/material/dialog';
import * as moment from 'moment';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-dashboard-page',
  templateUrl: './dashboard-page.component.html',
  styleUrls: ['./dashboard-page.component.scss']
})
export class DashboardPageComponent {

  public severityTableData: Attack[] = [];
  public recentTableData: Attack[] = [];
  public chartData: ChartCounter[] = [];
  public timelineData: Timeline[] = [];
  public counters: Counter[] = [];
  params = new HttpParams();
  variableDate = new Date;
  choosedDate = {startDate: null, endDate: null};
  

  constructor(private service: DashboardService, public dialog: MatDialog, private _snackBar: MatSnackBar) {
    
  }

  public ngOnInit() {
    this.getRecentTableData(this.params);
    this.getSeverityTableData(this.params);
    this.getCounters(this.params);
    this.getTimelineData(this.params);
    this.getChartData(this.params);
    // if (this.severityTableData.length == 0) {
    //   let snackBarRef = this._snackBar.open('No data to show', null, {
    //     duration: 2500,
    //     horizontalPosition: 'center',
    //     verticalPosition: 'top',
        
    //   });
    //}
  }

  getSeverityTableData(params: HttpParams): void {
    this.service.loadSeverityTableData(params)
      .subscribe(result => {
        this.severityTableData = result;
      });
  }

  getRecentTableData(params: HttpParams): void {
    this.service.loadRecentTableData(params)
      .subscribe(result => {
        this.recentTableData = result;
      });
  }

  getCounters(params: HttpParams): void {
    this.service.loadCounter(params)
      .subscribe(result => {
        this.counters = result;
      });
  }

  getTimelineData(params: HttpParams): void {
    this.service.loadTimelineData(params)
      .subscribe(result => {
        this.timelineData = result;
      });
  }

  getChartData(params: HttpParams): void {
    this.service.loadChartData(params)
      .subscribe(result => {
        this.chartData = result;
      });
  }

  public pushDateRange(event: AircalResponse): void {
    this.params = this.params.set("startDate", event.startDate.toISOString()).set("endDate", event.endDate.toISOString());
    this.getRecentTableData(this.params);
    this.getSeverityTableData(this.params);
    this.getCounters(this.params);
    this.getTimelineData(this.params);
    this.getChartData(this.params);
    // if (this.severityTableData.length == 0) {
    //   let snackBarRef = this._snackBar.open('No data to show', null, {
    //     duration: 2500,
    //     horizontalPosition: 'center',
    //     verticalPosition: 'top',
    //   });
    // }
  }
}

// @Component({
//   selector: 'noDataDialog',
//   templateUrl: 'noDataDialog.html',
// })
// export class NoDataDialog { }

   //   Observable
    // .interval(2*60*1000)
    // .timeInterval()
    // .flatMap(() => this.service.loadSeverityTableData(params)
    // .subscribe(result => {
    //   this.severityTableData = result;
    // });
    // this.interval = setInterval(() => {
    //   this.service.loadRecentTableData(params)  
    //   .subscribe(result => {
    //     this.recentTableData = result;
    //   });}, 1 * 30 * 1000);
    //   debugger
      // const nodeInterval =  NodeJS.Timeout = setInterval(() => {
  //   // do something
  // }, 1000);
  // setInterval(){
  //   this.getRecentTableData(this.params);
  // };
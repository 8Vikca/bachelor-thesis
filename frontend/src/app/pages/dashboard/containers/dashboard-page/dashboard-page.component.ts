import { Component } from '@angular/core';
import { Observable, interval } from 'rxjs';
import { DashboardService } from '../../services';
import {
  Attack,
  Counter,
  DailyLineChartData,
} from '../../models';
import { HttpParams } from '@angular/common/http';
import { AircalResponse } from 'ngx-aircal';

@Component({
  selector: 'app-dashboard-page',
  templateUrl: './dashboard-page.component.html',
  styleUrls: ['./dashboard-page.component.scss']
})
export class DashboardPageComponent {

  public severityTableData: Attack[];
  public recentTableData: Attack[];    //Observable<Attack[]>
  public ipGraphData: Attack[];
  public timelineData: Attack[];
  public counters: Counter[];
  params = new HttpParams();
  variableDate = new Date;
  //params2 = new HttpParams().set("startDate", this.startDate.toISOString()).set("endDate", this.date.toISOString());

  public ngOnInit() {
    this.getRecentTableData(this.params);
    this.getSeverityTableData(this.params);
    this.getCounters(this.params);
    this.getTimelineData(this.params);
  }
  getSeverityTableData(params: HttpParams): void {

    this.service.loadSeverityTableData(params)
      .subscribe(result => {
        this.severityTableData = result;
      });
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
 
  // const nodeInterval =  NodeJS.Timeout = setInterval(() => {
  //   // do something
  // }, 1000);

  setInterval(){
    this.getRecentTableData(this.params);
  };

  public pushDateRange(event: AircalResponse): void {
    this.params = this.params.set("startDate", event.startDate.toISOString()).set("endDate", event.endDate.toISOString());
    this.getRecentTableData(this.params);
    this.getSeverityTableData(this.params);
    this.getCounters(this.params);
  }


  public dailyLineChartData$: Observable<DailyLineChartData>;

  constructor(private service: DashboardService) {
    this.dailyLineChartData$ = this.service.loadDailyLineChartData();
  }
}

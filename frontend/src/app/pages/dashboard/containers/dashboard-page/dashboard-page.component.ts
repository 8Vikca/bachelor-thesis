import { Component } from '@angular/core';
import { Observable } from 'rxjs';

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
  public counters: Counter[];
  params = new HttpParams();
  variableDate = new Date;
  //params2 = new HttpParams().set("startDate", this.startDate.toISOString()).set("endDate", this.date.toISOString());

  public ngOnInit() {
    this.getRecentTableData(this.params);
    this.getSeverityTableData(this.params);
    this.getIPGraphData(this.params);
    this.getCounters(this.params);
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
  getIPGraphData(params: HttpParams): void {
    this.service.loadIPGraphData(params)
      .subscribe(result => {
        this.ipGraphData = result;
      });
  }
  getCounters(params: HttpParams): void {
    this.service.loadCounter(params)
      .subscribe(result => {
        this.counters = result;
      });
  }

  public pushDateRange(event: AircalResponse): void {
    event.startDate.setHours(0, 0, 0, 0);
    event.endDate.setHours(23, 59, 59, 59);
    this.params = this.params.set("startDate", event.startDate.toISOString()).set("endDate", event.endDate.toISOString());
    this.getRecentTableData(this.params);
    this.getSeverityTableData(this.params);
    this.getIPGraphData(this.params);
    this.getCounters(this.params);
  }


  public dailyLineChartData$: Observable<DailyLineChartData>;

  constructor(private service: DashboardService) {
    this.dailyLineChartData$ = this.service.loadDailyLineChartData();
  }
}

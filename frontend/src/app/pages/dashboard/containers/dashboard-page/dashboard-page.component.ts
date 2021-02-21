import { Component } from '@angular/core';
import { Observable } from 'rxjs';

import { DashboardService } from '../../services';
import {
  Attack,
  DailyLineChartData,
  PerformanceChartData,
  ProjectStatData,
  RevenueChartData,
  ServerChartData,
  SupportRequestData,
  VisitsChartData
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
  params = new HttpParams();
  variableDate = new Date;
  //params2 = new HttpParams().set("startDate", this.startDate.toISOString()).set("endDate", this.date.toISOString());

  public ngOnInit() {
    this.getRecentTableData(this.params);
    this.getSeverityTableData(this.params);
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

  public pushDateRange(event: AircalResponse): void {
    // if(event.endDate == null|) {
    //   event.endDate = event.
    // }
    // if (event.endDate < event.startDate) {
    //   this.variableDate = event.startDate;
    //   event.startDate = event.endDate;
    //   event.endDate = this.variableDate;
    // }
    event.startDate.setHours(0, 0, 0, 0);
    event.endDate.setHours(23, 59, 59, 59);
    this.params = this.params.set("startDate", event.startDate.toISOString()).set("endDate", event.endDate.toISOString());
    debugger
    this.getRecentTableData(this.params);
    this.getSeverityTableData(this.params)
  }






  public dailyLineChartData$: Observable<DailyLineChartData>;
  public performanceChartData$: Observable<PerformanceChartData>;
  public revenueChartData$: Observable<RevenueChartData>;
  public serverChartData$: Observable<ServerChartData>;
  public supportRequestData$: Observable<SupportRequestData[]>;
  public visitsChartData$: Observable<VisitsChartData>;
  public projectsStatsData$: Observable<ProjectStatData>;

  constructor(private service: DashboardService) {
    this.dailyLineChartData$ = this.service.loadDailyLineChartData();
    this.performanceChartData$ = this.service.loadPerformanceChartData();
    this.revenueChartData$ = this.service.loadRevenueChartData();
    this.serverChartData$ = this.service.loadServerChartData();
    this.supportRequestData$ = this.service.loadSupportRequestData();
    this.visitsChartData$ = this.service.loadVisitsChartData();
    this.projectsStatsData$ = this.service.loadProjectsStatsData();
  }
}

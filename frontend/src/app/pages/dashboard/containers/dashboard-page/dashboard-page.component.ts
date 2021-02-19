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

@Component({
  selector: 'app-dashboard-page',
  templateUrl: './dashboard-page.component.html',
  styleUrls: ['./dashboard-page.component.scss']
})
export class DashboardPageComponent {

  public severityTableData: Attack[];
  public recentTableData: Attack[];    //Observable<Attack[]>
  endDate= new Date(2020,10, 26);
  date= new (Date);
  startDate = new Date(this.date.setDate(this.date.getDate()-1));
  params = new HttpParams().set("startDate", this.startDate.toISOString()).set("endDate", this.endDate.toISOString());
  
  public ngOnInit() {
    this.getRecentTableData(this.params);
    this.getSeverityTableData();
  }
  getSeverityTableData(): void {
    this.service.loadSeverityTableData()
      .subscribe(result => {
        this.severityTableData = result;
      });
  }
  getRecentTableData(params: HttpParams): void {
    this.service.loadRecentTableData(params)
      .subscribe(result => {
        this.recentTableData = result;       
      });
      console.log('data from server' + this.recentTableData); 
  }

  public pushDateRange(date: any):void {
    // console.log('Picked date: ', date);
    // this.params.set("startDate", date.startDate).set("endDate", date.endDate);
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

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
  public counters: Counter;
  params = new HttpParams();
  variableDate = new Date;
  choosedDate = { startDate: null, endDate: null };

  constructor(private service: DashboardService, public dialog: MatDialog, private _snackBar: MatSnackBar) {
    this.choosedDate = {
      startDate: moment().set({ hours: 0, minutes: 0, seconds: 0, milliseconds: 0 }),
      endDate: moment().set({ hours: 23, minutes: 59, seconds: 59, milliseconds: 999 })
    };

    this.params = this.params.set("startDate", this.choosedDate.startDate.toISOString()).set("endDate", this.choosedDate.endDate.toISOString());
  }

  public ngOnInit() {
    this.getSeverityTableData(this.params);
    this.getRecentTableData(this.params);
    this.getCounters(this.params);
    this.getTimelineData(this.params);
    this.getChartData(this.params);
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
        if (this.recentTableData.length == 0) {
          this._snackBar.open('No data to show', null, {
            duration: 2500,
            horizontalPosition: 'center',
            verticalPosition: 'top',
            panelClass: ['snackbar']
          });
        }
      }
      );
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
  }
}
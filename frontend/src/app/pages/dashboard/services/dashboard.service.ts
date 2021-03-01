import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

import {
  DailyLineChartData,
  Attack,
  Counter
} from '../models';


@Injectable({
  providedIn: 'root'
})
export class DashboardService {
  
  constructor(private http: HttpClient) { }

  loadSeverityTableData(params: HttpParams): Observable<Attack[]> {   
     return this.http.get<Attack[]>("https://localhost:44386/severityData", {params: params});     
   }
   loadRecentTableData(params: HttpParams): Observable<Attack[]> { 
    return this.http.get<Attack[]>("https://localhost:44386/recentData", {params: params});  
  }
  loadIPGraphData(params: HttpParams): Observable<Attack[]> {   
    return this.http.get<Attack[]>("https://localhost:44386/graphData", {params: params});     
  }
  loadCounter(params: HttpParams): Observable<Counter[]> {   
    return this.http.get<Counter[]>("https://localhost:44386/counter", {params: params});     
  }


  
  
  public loadDailyLineChartData(): Observable<DailyLineChartData> {
    return of({
      dailyData: {
        mobile: [16, 46, 45, 12, 37, 16, 41, 13, 25, 22, 30],
        desktop: [42, 60, 49, 50, 13, 15, 16, 57, 56, 27, 43],
        tablet: [35, 25, 36, 30, 67, 35, 64, 12, 25, 36, 39]
      },
      weeklyData: {
        mobile: [23, 31, 45, 10, 37, 67, 43, 63, 15, 22, 30],
        desktop: [67, 60, 49, 50, 25, 15, 16, 57, 13, 27, 43],
        tablet: [56, 48, 23, 48, 13, 35, 64, 12, 45, 36, 39]
      },
      monthlyData: {
        mobile: [23, 11, 22, 27, 13, 22, 37, 21, 44, 22, 30],
        desktop: [44, 55, 41, 67, 22, 43, 21, 41, 56, 27, 43],
        tablet: [30, 25, 36, 30, 45, 35, 64, 52, 59, 36, 39]
      },
      labels: [
        '01/01/2003',
        '02/01/2003',
        '03/01/2003',
        '04/01/2003',
        '05/01/2003',
        '06/01/2003',
        '07/01/2003',
        '08/01/2003',
        '09/01/2003',
        '10/01/2003',
        '11/01/2003'
      ]
    });
  }
}

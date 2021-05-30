import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment} from '../../../../environments/environment'

import {
  Attack,
  ChartCounter,
  Counter,
  Timeline
} from '../models';


@Injectable({
  providedIn: 'root'
})
export class DashboardService {       //service na pracu s dashboard
  
  constructor(private http: HttpClient) { }

  loadSeverityTableData(params: HttpParams): Observable<Attack[]> {   
     return this.http.get<Attack[]>(environment.apiUrl + "/severityData", {params: params});     
   }
   loadRecentTableData(params: HttpParams): Observable<Attack[]> { 
    return this.http.get<Attack[]>(environment.apiUrl + "/recentData", {params: params});  
  }
  loadChartData(params: HttpParams): Observable<ChartCounter[]> {   
    return this.http.get<ChartCounter[]>(environment.apiUrl + "/chartData", {params: params});     
  }
  loadCounter(params: HttpParams): Observable<Counter> {   
    return this.http.get<Counter>(environment.apiUrl + "/counter", {params: params});     
  }
  loadTimelineData(params: HttpParams): Observable<Timeline[]> { 
    return this.http.get<Timeline[]>(environment.apiUrl + "/timelineData", {params: params});  
  }
}

import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../../../environments/environment'

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

  authtoken = localStorage.getItem("token");

  headers_object = new HttpHeaders().set("Authorization", "Bearer " + this.authtoken);



constructor(private http: HttpClient) { }

loadSeverityTableData(params: HttpParams): Observable < Attack[] > {
  const options = { params: params, headers: this.headers_object };
  return this.http.get<Attack[]>(environment.apiUrl + "/severityData", { params: params, headers: this.headers_object });
}
loadRecentTableData(params: HttpParams): Observable < Attack[] > {
  return this.http.get<Attack[]>(environment.apiUrl + "/recentData", { params: params, headers: this.headers_object });
}
loadChartData(params: HttpParams): Observable < ChartCounter[] > {
  return this.http.get<ChartCounter[]>(environment.apiUrl + "/chartData", { params: params, headers: this.headers_object });
}
loadCounter(params: HttpParams): Observable < Counter > {
  return this.http.get<Counter>(environment.apiUrl + "/counter", { params: params, headers: this.headers_object });
}
loadTimelineData(params: HttpParams): Observable < Timeline[] > {
  return this.http.get<Timeline[]>(environment.apiUrl + "/timelineData", { params: params, headers: this.headers_object });
}
}

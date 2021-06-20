import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Attack } from '../models/attack';
import { Observable} from 'rxjs';
import { environment } from 'src/environments/environment';


@Injectable({
  providedIn: 'root'
})
export class TableService {           //service na pracu v Investigation

  authtoken = localStorage.getItem("token");

  headers_object = new HttpHeaders().set("Authorization", "Bearer " + this.authtoken);

  constructor(private http: HttpClient) { }

  loadAllTableData(): Observable<Attack[]> {   
     return this.http.get<Attack[]>(environment.apiUrl + "/allData", {headers: this.headers_object});     
   }
   loadFilteredData(params: HttpParams): Observable<Attack[]> {   
    return this.http.get<Attack[]>(environment.apiUrl + "/filteredData", { params: params, headers: this.headers_object });     
  }

}

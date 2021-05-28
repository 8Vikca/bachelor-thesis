import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Attack } from '../models/attack';
import { Observable} from 'rxjs';
import { environment } from 'src/environments/environment';


@Injectable({
  providedIn: 'root'
})
export class TableService {        

  constructor(private http: HttpClient) { }

  loadAllTableData(): Observable<Attack[]> {   
     return this.http.get<Attack[]>(environment.apiUrl + "/allData");     
   }
   loadFilteredData(params: HttpParams): Observable<Attack[]> {   
    return this.http.get<Attack[]>(environment.apiUrl + "/filteredData", {params: params});     
  }

}

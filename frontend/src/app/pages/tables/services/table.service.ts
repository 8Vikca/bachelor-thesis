import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Attack } from '../models/attack';
import { Observable} from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class TableService {        


  constructor(private http: HttpClient) { }

  loadAllTableData(): Observable<Attack[]> {   
     return this.http.get<Attack[]>("https://localhost:44386/search");     
   }


}

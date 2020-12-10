import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Attack } from 'src/shared/attack';
import { Observable, of } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class TableService {        //pripojenie sa na backend

  constructor(private http: HttpClient) { }

  getAttacks(): Observable<Attack[]> {   
    return this.http.get<Attack[]>("https://localhost:44386/search");
  }
}

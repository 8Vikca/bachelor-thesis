import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Attack } from 'src/shared/attack';
import { Observable, of } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class TableService {

  constructor(private http: HttpClient) { }

  getAttacks(): Observable<Attack[]> { //pageIndex: number, pageSize: number
    return this.http.get<Attack[]>("https://localhost:44386/search");
  }
}

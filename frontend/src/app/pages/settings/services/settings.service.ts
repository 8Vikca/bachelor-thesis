import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SettingsService {

  constructor(private http: HttpClient) { }
  
  public sign(credentials: any): Observable<any> {
    debugger
    return this.http.post<any>("https://localhost:44386/register", credentials); 
    //localStorage.setItem('token', 'token');
  }
}

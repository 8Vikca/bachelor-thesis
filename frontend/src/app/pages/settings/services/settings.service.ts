import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SettingsService {

  constructor(private http: HttpClient) { }
  
  public sign(credentials: any): Observable<any> {
    return this.http.post<any>("https://localhost:44386/register", credentials, { observe: 'response' }); 
  }
  public updateUser(userInfo: any): Observable<any> {
    return this.http.post<any>("https://localhost:44386/updateUser", userInfo, { observe: 'response' }); 
  }
  public updatePassword(userPassword: any): Observable<any> {
    debugger
    return this.http.post<any>("https://localhost:44386/updatePassword", userPassword, { observe: 'response' }); 
  }
}

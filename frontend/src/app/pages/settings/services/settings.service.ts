import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class SettingsService {      //service na pracu s nastaveniami

  constructor(private http: HttpClient) { }
  
  public sign(credentials: any): Observable<any> {
    return this.http.post<any>(environment.apiUrl + "/register", credentials, { observe: 'response' }); 
  }
  public updateUser(userInfo: any): Observable<any> {
    return this.http.post<any>(environment.apiUrl + "/updateUser", userInfo, { observe: 'response' }); 
  }
  public updatePassword(userPassword: any): Observable<any> {
    return this.http.post<any>(environment.apiUrl + "/updatePassword", userPassword, { observe: 'response' }); 
  }
  public getUsers(): Observable<any> {
    return this.http.get<any>(environment.apiUrl + "/getUsers"); 
  }
  public deleteUser(userId: any): Observable<any> {
    return this.http.post<any>(environment.apiUrl + "/deleteUser", userId, { observe: 'response' }); 
  }
}

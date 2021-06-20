import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class SettingsService {      //service na pracu s nastaveniami

  authtoken = localStorage.getItem("token");

  headers_object = new HttpHeaders().set("Authorization", "Bearer " + this.authtoken);

  constructor(private http: HttpClient) { }
  
  public sign(credentials: any): Observable<any> {
    return this.http.post<any>(environment.apiUrl + "/register", credentials, { observe: 'response', headers: this.headers_object }); 
  }
  public updateUser(userInfo: any): Observable<any> {
    return this.http.post<any>(environment.apiUrl + "/updateUser", userInfo, { observe: 'response', headers: this.headers_object }); 
  }
  public updatePassword(userPassword: any): Observable<any> {
    return this.http.post<any>(environment.apiUrl + "/updatePassword", userPassword, { observe: 'response', headers: this.headers_object }); 
  }
  public getUsers(): Observable<any> {
    return this.http.get<any>(environment.apiUrl + "/getUsers", {headers: this.headers_object}); 
  }
  public deleteUser(userId: any): Observable<any> {
    return this.http.post<any>(environment.apiUrl + "/deleteUser", userId, { observe: 'response', headers: this.headers_object }); 
  }
}

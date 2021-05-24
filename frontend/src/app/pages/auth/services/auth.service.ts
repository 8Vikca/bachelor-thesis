import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { Observable, of } from 'rxjs';
import { environment } from 'src/environments/environment';

import { User } from '../models';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  constructor(private http: HttpClient, private jwtHelper: JwtHelperService) {
  }

  currentUser: User = {
    name:null,
    surname: null,
    role: null,
    email: null
  }

  public login(credentials: any): Observable<any> {
      return this.http.post<any>(environment.apiUrl + "/login", credentials); 
  }

  public sign(credentials: any): Observable<any> {
    return this.http.post<any>(environment.apiUrl + "/register", credentials); 
    //localStorage.setItem('token', 'token');
  }
  public refresh(credentials: any): Observable<any> {
    return this.http.post<any>(environment.apiUrl + "/refresh", credentials, {
      headers: new HttpHeaders({
        "Content-Type": "application/json"
      }),
      observe: 'response'
    }
    ); 
  }

  public signOut(): void {
    localStorage.removeItem("token");
    localStorage.removeItem("refreshToken");
  }

  public getUser(): Observable<User> {
    const token = localStorage.getItem("token");
    const decodedToken = this.jwtHelper.decodeToken(token);
      this.currentUser.name = decodedToken['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name'];
      this.currentUser.surname = decodedToken['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname'];
      this.currentUser.email = decodedToken['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress'];
      this.currentUser.role = decodedToken['http://schemas.microsoft.com/ws/2008/06/identity/claims/role'];
    return of({
      name: this.currentUser.name,
      surname: this.currentUser.surname,
      role: this.currentUser.role,
      email: this.currentUser.email
    });
  }

  public newData(): Observable<any> {
    return this.http.get<any>(environment.apiUrl + "/dataElastic"); 
  }
}

import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

import { User } from '../models';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  constructor(private http: HttpClient) {

  }
  public login(credentials: any): Observable<any> {
      return this.http.post<any>("https://localhost:44386/login", credentials); 
  }

  public sign(credentials: any): Observable<any> {
    return this.http.post<any>("https://localhost:44386/register", credentials); 
    //localStorage.setItem('token', 'token');
  }

  public signOut(): void {
    localStorage.removeItem("jwt");
  }

  public getUser(): Observable<User> {
    return of({
      name: 'John',
      lastName: 'Smith'
    });
  }
}

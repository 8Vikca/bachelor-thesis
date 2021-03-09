import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Attack } from '../../dashboard/models';

import { User } from '../models';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  constructor(private http: HttpClient) {

  }
  public login(): void {
    localStorage.setItem('token', 'token');
  }
  
  // sendCredentials(): Observable<Attack[]> {
  //   return this.http.post("https://localhost:44386/login", credentials);
  // }
  public sign(): void {
    localStorage.setItem('token', 'token');
  }

  public signOut(): void {
    localStorage.removeItem('token');
  }

  public getUser(): Observable<User> {
    return of({
      name: 'John',
      lastName: 'Smith'
    });
  }
}

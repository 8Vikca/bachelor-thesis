import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Attack } from '../models/attack';
import { Observable, of, throwError } from 'rxjs';
import { catchError, tap} from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class TableService {        

  // public loadEmployeeTableData(): Observable<Attack[]> {
  //   return of([
  //     {id:'1', message: 'Joe James', severity: 'Example Inc.', timestamp: 'Yonkers', proto: 'NY', src_ip: '1.211.235', dest_ip: 'ha'},
  //     {id:'2', message: 'John Walsh', severity: 'Example Inc.', timestamp: 'Hartford', proto: 'CT', src_ip: 'bla', dest_ip: 'ha'},
  //     {id:'3', message: 'Bob Herm', severity: 'Example Inc.', timestamp: 'Tampa', proto: 'FL', src_ip: 'bla', dest_ip: 'ha'},
  //     {id:'4', message: 'James Houston', severity: 'Example Inc.', timestamp: 'Dallas', proto: 'TX', src_ip: 'bla', dest_ip: 'ha'},
  //     {id:'5', message: 'Feri Linwood', severity: 'Example Inc.', timestamp: 'Hartford', proto: 'CT', src_ip: 'bla', dest_ip: 'ha'},
  //     {id:'6', message: 'Steve Linwood', severity: 'Example Inc.', timestamp: 'Tampa', proto: 'CT', src_ip: 'bla', dest_ip: 'ha'},
  //     {id:'7', message: 'Chuan Linwood', severity: 'Example Inc.', timestamp: 'Yonkers', proto: 'CT', src_ip: 'bla', dest_ip: 'ha'},
  //     {id:'8', message: 'Apolo Linwood', severity: 'Example Inc.', timestamp: 'Tampa', proto: 'CT', src_ip: 'bla', dest_ip: 'ha'},
  //     {id:'9', message: 'Josh Linwood', severity: 'Example Inc.', timestamp: 'Yonkers', proto: 'CT', src_ip: 'bla', dest_ip: 'ha'},
  //     {id:'10', message: 'Joe Linwood', severity: 'Example Inc.', timestamp: 'Hartford', proto: 'CT', src_ip: 'bla', dest_ip: 'ha'},
  //     {id:'11', message: 'Ross Linwood', severity: 'Example Inc.', timestamp: 'Tampa', proto: 'CT', src_ip: 'bla', dest_ip: 'ha'},
  //     {id:'12', message: 'Pam Linwood', severity: 'Example Inc.', timestamp: 'Hartford', proto: 'CT', src_ip: 'bla', dest_ip: 'ha'},
  //     {id:'13', message: 'Monica Linwood', severity: 'Example Inc.', timestamp: 'Yonkers', proto: 'CT', src_ip: 'bla', dest_ip: 'ha'}
  //   ]);
  // }


  constructor(private http: HttpClient) { }

  loadEmployeeTableData(): Observable<Attack[]> {   
     return this.http.get<Attack[]>("https://localhost:44386/search");     
   }

private handleError(err: HttpErrorResponse) {     //Handle Http operation that failed.
  let errorMessage = '';
  if (err.error instanceof ErrorEvent) {
    errorMessage= `An error occurred: ${err.error.message}`; //client-side or network error
  } else {
    errorMessage= `Server returned code: ${err.status}, error message is: ${err.message}`; //backend return an unsuccesful respone code
  }
  console.error(errorMessage);
  return throwError(errorMessage);
  }

}

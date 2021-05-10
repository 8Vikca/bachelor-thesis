import { Component, Input, EventEmitter } from '@angular/core';
import { Router } from '@angular/router';

import { AuthService } from '../../services';
import { routes } from '../../../../consts';
import { Form } from '@angular/forms';
import { Observable } from 'rxjs';
import { User } from '../../models';
import { JwtHelperService } from '@auth0/angular-jwt';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-auth-page',
  templateUrl: './auth-page.component.html',
  styleUrls: ['./auth-page.component.scss']
})
export class AuthPageComponent {
  public todayDate: Date = new Date();
  public routers: typeof routes = routes;

  constructor(
    private service: AuthService,
    private router: Router,
    private _snackBar: MatSnackBar
  ) { }

  public sendLoginForm(loginForm: any): void { 
    this.service.login(loginForm).subscribe(response => {
      const token = (<any>response).token;
      const refreshToken = (<any>response).refreshToken;
      localStorage.setItem("token", token);
      localStorage.setItem("refreshToken", refreshToken);
      this.router.navigate([this.routers.DASHBOARD]);   //.then();
    },
    (err) => {
      let snackBarRef = this._snackBar.open('Incorrect email or password', null, { 
        duration: 2500,
        horizontalPosition: 'center',
        verticalPosition: 'top',
        panelClass: ['mat-toolbar', 'mat-warn']
      }); 
    });
  }

  // public sendSignForm(signForm: any): void {
  //   this.service.sign(signForm).subscribe(response => {
  //     const token = (<any>response).token;
  //     const refreshToken = (<any>response).refreshToken;
  //     localStorage.setItem("token", token);
  //     localStorage.setItem("refreshToken", refreshToken);
  //     //this.router.navigate([this.routers.DASHBOARD]);;
  //   })
  // }
}

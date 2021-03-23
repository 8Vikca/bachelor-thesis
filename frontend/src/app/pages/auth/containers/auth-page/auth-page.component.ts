import { Component, Input, EventEmitter } from '@angular/core';
import { Router } from '@angular/router';

import { AuthService } from '../../services';
import { routes } from '../../../../consts';
import { Form } from '@angular/forms';
import { Observable } from 'rxjs';
import { User } from '../../models';

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
    private router: Router
  ) { }


  public sendLoginForm(loginForm: any): void {  //form: Form
    this.service.login(loginForm).subscribe(response => {
      const token = (<any>response).token;
      const refreshToken = (<any>response).refreshToken;
      localStorage.setItem("token", token);
      localStorage.setItem("refreshToken", refreshToken);
      this.router.navigate([this.routers.DASHBOARD]);   //.then();
    })
  }

  public sendSignForm(signForm: any): void {
    debugger
    this.service.sign(signForm).subscribe(response => {
      const token = (<any>response).token;
      const refreshToken = (<any>response).refreshToken;
      localStorage.setItem("token", token);
      localStorage.setItem("refreshToken", refreshToken);
      //this.router.navigate([this.routers.DASHBOARD]);;
    })
  }
}

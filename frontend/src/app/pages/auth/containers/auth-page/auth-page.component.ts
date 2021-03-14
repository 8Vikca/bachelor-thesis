import { Component, Input, EventEmitter } from '@angular/core';
import { Router } from '@angular/router';

import { AuthService } from '../../services';
import { routes } from '../../../../consts';
import { Form } from '@angular/forms';

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
      localStorage.setItem("token", token);
      this.router.navigate([this.routers.DASHBOARD]);   //.then();
    })
  }

  public sendSignForm(signForm: any): void {
    debugger
    this.service.sign(signForm).subscribe(response => {
      const token = (<any>response).token;
      localStorage.setItem("token", token);
      //this.router.navigate([this.routers.DASHBOARD]);;
    })
  }
}

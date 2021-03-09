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

  // getCounters(params: HttpParams): void {
  //   this.service.loadCounter(params)
  //     .subscribe(result => {
  //       this.counters = result;
  //     });
  // }

  public sendLoginForm(loginForm: any): void {  //form: Form
    console.log();
    debugger
    this.service.login();
    this.router.navigate([this.routers.DASHBOARD]).then();
  }

  public sendSignForm(): void {
    this.service.sign();

    this.router.navigate([this.routers.DASHBOARD]).then();
  }
}

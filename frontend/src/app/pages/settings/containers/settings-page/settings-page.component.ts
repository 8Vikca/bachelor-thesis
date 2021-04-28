import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { routes } from 'src/app/consts';
import { SettingsService } from '../../services/settings.service';

@Component({
  selector: 'app-settings-page',
  templateUrl: './settings-page.component.html',
  styleUrls: ['./settings-page.component.scss']
})
export class SettingsPageComponent implements OnInit {
  public routers: typeof routes = routes;
  
  constructor(
    private service: SettingsService, private router: Router) { }

  ngOnInit(): void {
  }

  public sendRegisterForm(signForm: any): void {
    this.service.sign(signForm).subscribe(response => {
      // const token = (<any>response).token;
      // const refreshToken = (<any>response).refreshToken;
      // localStorage.setItem("token", token);
      // localStorage.setItem("refreshToken", refreshToken);
      this.router.navigate([this.routers.DASHBOARD]);;
    })
  }
}

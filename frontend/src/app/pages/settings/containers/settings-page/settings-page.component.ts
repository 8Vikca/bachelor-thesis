import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
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
  durationInSeconds = 5;

  constructor(
    private service: SettingsService, private router: Router, private _snackBar: MatSnackBar) { }

  ngOnInit(): void {
  }


  public sendRegisterForm(signForm: any): void {
    this.service.sign(signForm).subscribe(response => {
      if (response.status == 200) {
        this.openRegisterSnackBar();
        this.router.navigate([this.routers.DASHBOARD]);
      }
    },
      (err) => {
        this.openNoAuthSnackBar();
      });
    // else {
    //   console.log("nope");
    //   //alert("There was a problem logging you out");
    //   this.openNoAuthSnackBar();
    //   //let snackBarRef = this._snackBar.open('Message archived');
    // }
    //})
  }
  openRegisterSnackBar() {
    this._snackBar.openFromComponent(RegisterSnackbarComponent, {
      duration: this.durationInSeconds * 1000,
    });
  }
  openNoAuthSnackBar() {
    this._snackBar.openFromComponent(NoAuthSnackbarComponent, {
      duration: this.durationInSeconds * 1000,
    });
  }
}
@Component({
  selector: 'register-snackbar',
  templateUrl: 'register-snackbar.html',
  styles: [`
    .example-pizza-party {
      color: hotpink;
    }
  `],
})
export class RegisterSnackbarComponent { }

@Component({
  selector: 'noAuth-snackbar',
  templateUrl: 'noAuth-snackbar.html',
  styles: [`
    .example-pizza-party {
      color: hotpink;
    }
  `],
})
export class NoAuthSnackbarComponent { }
import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { routes } from 'src/app/consts';
import { User } from 'src/app/pages/auth/models';
import { AuthService } from 'src/app/pages/auth/services';
import { UpdateUser } from '../../models/updateUser';
import { SettingsService } from '../../services/settings.service';

@Component({
  selector: 'app-settings-page',
  templateUrl: './settings-page.component.html',
  styleUrls: ['./settings-page.component.scss']
})
export class SettingsPageComponent {
  public routers: typeof routes = routes;
  durationInSeconds = 5;
  public user$: Observable<User>

  constructor(
    private service: SettingsService, private router: Router, private _snackBar: MatSnackBar, private userService: AuthService) {
    this.user$ = this.userService.getUser();
  }


  public sendUpdate(updateUser: UpdateUser) {
    if (updateUser.currentPassword != null || updateUser.newPassword != null) {
      this.sendPassword(updateUser);
    } else {
      this.service.updateUser(updateUser).subscribe(response => {
        if (response.status == 200) {
          let snackBarRef = this._snackBar.open('User info updated', null, {
            duration: 2500,
            horizontalPosition: 'center',
            verticalPosition: 'top',
            panelClass: ['snackbar']
          });
          //this.router.navigate([this.routers.DASHBOARD]);
        }
      },
        (err) => {
          let snackBarRef = this._snackBar.open('{{err}}', null, {
            duration: 2500,
            horizontalPosition: 'center',
            verticalPosition: 'top',
            panelClass: ['snackbar']
          });
        });
    }
  }
  public sendPassword(updateUser: UpdateUser) {
    this.service.updatePassword(updateUser).subscribe(response => {
      if (response.status == 200) {
        let snackBarRef = this._snackBar.open('Password changed', null, {
          duration: 2500,
          horizontalPosition: 'center',
          verticalPosition: 'top',
          panelClass: ['snackbar']
        });
      }
      this.router.navigate([this.routers.SETTINGS]);
    },
      (err) => {
        let snackBarRef = this._snackBar.open('Incorrect password', null, {
          duration: 2500,
          horizontalPosition: 'center',
          verticalPosition: 'top',
          panelClass: ['snackbar']
        });
      });
  }

  public sendRegisterForm(signForm: any): void {
    this.service.sign(signForm).subscribe(response => {
      if (response.status == 200) {
        let snackBarRef = this._snackBar.open('User created', null, {
          duration: 2500,
          horizontalPosition: 'center',
          verticalPosition: 'top',
          panelClass: ['snackbar']
        });
        this.router.navigate([this.routers.SETTINGS]);
      }
    },
      (err) => {
        let snackBarRef = this._snackBar.open('You are not authorized to create user!', null, {
          duration: 2500,
          horizontalPosition: 'center',
          verticalPosition: 'top',
          panelClass: ['snackbar']
        });
      });
    // else {
    //   console.log("nope");
    //   //alert("There was a problem logging you out");
    //   this.openNoAuthSnackBar();
    //   //let snackBarRef = this._snackBar.open('Message archived');
    // }
    //})
  }
}
import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { routes } from 'src/app/consts';
import { AuthService } from 'src/app/pages/auth/services';

@Component({
  selector: 'app-refresh',
  templateUrl: './refresh.component.html',
  styleUrls: ['./refresh.component.scss']
})
export class RefreshComponent implements OnInit {
  public routers: typeof routes = routes;
  constructor(private userService: AuthService, private router: Router, private _snackBar: MatSnackBar) { }

  ngOnInit(): void {
  }
  public newData(): void {
    this._snackBar.open('Refreshing data...', null, {
      horizontalPosition: 'center',
      verticalPosition: 'top',
      panelClass: ['snackbar']
    });
    this.userService.newData().subscribe(res => {
      window.location.reload();
    });
  }
}

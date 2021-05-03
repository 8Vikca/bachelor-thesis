import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { User } from '../../models';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.scss']
})
export class LoginFormComponent implements OnInit {
  @Output() loginEmitter = new EventEmitter<any>();
  public form: FormGroup;
  public flatlogicEmail = 'matusicovav@gmail.com';
  public flatlogicPassword = '987Vikinka';

  constructor(private _snackBar: MatSnackBar) {
  }

  public ngOnInit(): void {
    this.form = new FormGroup({
      email: new FormControl(this.flatlogicEmail, [Validators.required, Validators.email]),
      password: new FormControl(this.flatlogicPassword, [Validators.required])
    });
  }

  public login(): void {
    if (this.form.valid) {
      this.loginEmitter.emit(this.form.value); 
    }
    else {
      let snackBarRef = this._snackBar.open('Invalid form');
    }
  }
}

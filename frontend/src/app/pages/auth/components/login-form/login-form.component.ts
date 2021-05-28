import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { AuthService } from '../../services';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.scss']
})
export class LoginFormComponent implements OnInit {
  @Output() loginEmitter = new EventEmitter<any>();
  public form: FormGroup;

  constructor(private _snackBar: MatSnackBar, private userService: AuthService,) {
  }

  public ngOnInit(): void {
    this.form = new FormGroup({
      email: new FormControl("" , [Validators.required, Validators.email]),
      password: new FormControl("", [Validators.required])
    });
  }

  public login(): void {
    if (this.form.valid) {
      this.userService.newData().subscribe();
      this.loginEmitter.emit(this.form.value); 
    }
  }
}

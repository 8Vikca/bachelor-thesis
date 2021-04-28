import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';

interface Role {
  value: string;
  viewValue: string;
}

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  @Output() sendRegisterForm = new EventEmitter<void>();
  public form: FormGroup;
  hide = true;
  // selectedValue: string;
  durationInSeconds = 10;

  constructor(private _snackBar: MatSnackBar) {}

  public ngOnInit(): void {
    this.form = new FormGroup({
      firstName: new FormControl('', [Validators.required]),
      lastName: new FormControl('', [Validators.required]),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required]),
      role: new FormControl('', [Validators.required]),
    });
  }

  roles: Role[] = [
    {value: 'admin', viewValue: 'Admin'},
    {value: 'user', viewValue: 'User'},
  ];

  public sign(): void {
    if (this.form.valid) {
      this.sendRegisterForm.emit(this.form.value);
      this.openSnackBar();

      this.form.reset();
    }
  }
  openSnackBar() {
    this._snackBar.openFromComponent(RegisterSnackbarComponent, {
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
export class RegisterSnackbarComponent {}

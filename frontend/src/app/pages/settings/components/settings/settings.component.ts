import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Observable } from 'rxjs';
import { User } from 'src/app/pages/auth/models';
import { AuthService } from 'src/app/pages/auth/services';
import { UpdateUser } from '../../models/updateUser';

@Component({
  selector: 'app-settings',
  templateUrl: './settings.component.html',
  styleUrls: ['./settings.component.scss']
})
export class SettingsComponent implements OnInit {
  @Output() sendUpdate = new EventEmitter<UpdateUser>();
  @Input() user: User;
  public personalForm: FormGroup;
  public emailForm: FormGroup;
  public securityForm: FormGroup;
  hide = true;
  hide2 = true;
  updateUser: UpdateUser = {name: null, surname: null, email: null, currentPassword: null, newPassword:null};

  constructor(private _snackBar: MatSnackBar) {
   }

  public ngOnInit(): void {
    this.personalForm = new FormGroup({
      firstName: new FormControl(''),
      lastName: new FormControl(''),
    });
    this.securityForm = new FormGroup({
      currentPassword: new FormControl('', Validators.required),
      newPassword: new FormControl('', [Validators.required, Validators.pattern(/^(?=\D*\d)(?=[^a-z]*[a-z])(?=[^A-Z]*[A-Z]).{8,30}$/)]),
    });
    this.personalForm.setValue({firstName: this.user.name, lastName: this.user.surname});
 
  }
  step = 0;

  setStep(index: number) {
    this.step = index;
  }

  updateInfo() {
    if (this.personalForm.valid) {
      this.updateUser.name = this.personalForm.controls['firstName'].value;
      this.updateUser.surname = this.personalForm.controls['lastName'].value;      
      this.updateUser.email = this.user.email
      this.sendUpdate.emit(this.updateUser);
      let snackBarRef = this._snackBar.open('Personal data updated', null, {
        duration: 2500,
        horizontalPosition: 'center',
        verticalPosition: 'top',
        panelClass: ['snackbar']
      });
    }
  }

  updatePassword() {
    if (this.securityForm.valid) {
      this.updateUser.currentPassword = this.securityForm.controls['currentPassword'].value;
      this.updateUser.newPassword = this.securityForm.controls['newPassword'].value;      
      this.updateUser.email = this.user.email;
      this.sendUpdate.emit(this.updateUser);
      this.securityForm.reset();
    }
  }

  nextStep() {
    this.step++;
  }

  prevStep() {
    this.step--;
  }
}

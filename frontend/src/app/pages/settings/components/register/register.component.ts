import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

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

  constructor() {}

  public ngOnInit(): void {
    this.form = new FormGroup({       //kontrola inputu
      firstName: new FormControl('', [Validators.required]),
      lastName: new FormControl('', [Validators.required]),
      email: new FormControl('', [Validators.required, Validators.email]),
      password: new FormControl('', [Validators.required, Validators.pattern(/^(?=\D*\d)(?=[^a-z]*[a-z])(?=[^A-Z]*[A-Z]).{8,30}$/)]),
      role: new FormControl('', [Validators.required]),
    });
  }

  roles: Role[] = [
    {value: 'admin', viewValue: 'Admin'},
    {value: 'user', viewValue: 'User'},
  ];

  public sign(): void {     //odoslat registracny formular
    if (this.form.valid) {
      this.sendRegisterForm.emit(this.form.value);
    }
  }
  
}



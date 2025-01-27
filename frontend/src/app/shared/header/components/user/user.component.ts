import { Component, EventEmitter, Input, Output } from '@angular/core';
import { routes } from '../../../../consts';
import { User } from '../../../../pages/auth/models';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})

export class UserComponent {
  @Input() user: User;
  @Output() signOut: EventEmitter<void> = new EventEmitter<void>();
  public routes: typeof routes = routes;

  constructor() {
  }

  public signOutEmit(): void {      //logout uzivatela
    this.signOut.emit();
  }
}

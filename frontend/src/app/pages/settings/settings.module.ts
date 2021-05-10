import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SettingsPageComponent } from './containers/settings-page/settings-page.component';
import { SettingsRoutingModule } from './settings-routing.module';
import { SharedModule } from 'src/app/shared/shared.module';
import { MatTabsModule } from '@angular/material/tabs';
import { RegisterComponent } from './components/register/register.component';
import { SettingsComponent } from './components/settings/settings.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatCardModule } from '@angular/material/card';
import { MatNativeDateModule } from '@angular/material/core';
import { MatSelectModule } from '@angular/material/select';
import { MatIconModule } from '@angular/material/icon';
import { MatGridListModule } from '@angular/material/grid-list';
import {MatSnackBarModule} from '@angular/material/snack-bar';
import {MatExpansionModule} from '@angular/material/expansion';



@NgModule({
  declarations: [
    SettingsPageComponent,
    RegisterComponent,
    SettingsComponent,
  ],
  imports: [
    CommonModule,
    SettingsRoutingModule,
    SharedModule,
    MatTabsModule,
    MatFormFieldModule,
    ReactiveFormsModule,
    MatTabsModule,
    MatButtonModule,
    MatInputModule,
    FormsModule,
    MatCardModule,
    MatNativeDateModule,
    MatInputModule,
    MatSelectModule,   
    MatIconModule, 
    MatGridListModule,
    MatSnackBarModule,
    MatExpansionModule
  ]
})
export class SettingsModule { }

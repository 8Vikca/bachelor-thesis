import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatCardModule} from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { MatMenuModule } from '@angular/material/menu';
import { MatTableModule } from '@angular/material/table';
import { MatButtonModule } from '@angular/material/button';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatFormFieldModule } from '@angular/material/form-field';
import { TablePageComponent } from './containers';
import { TablesRoutingModule } from './tables-routing.module';
import { SharedModule } from '../../shared/shared.module';
import { AttacksTableComponent } from './components';
import { TableService } from './services';
import { MatSortModule } from '@angular/material/sort';
import { FilterComponent } from './components/filter/filter.component';
import {AutocompleteLibModule} from 'angular-ng-autocomplete';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { MatInputModule } from '@angular/material/input';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {DashboardModule} from '../dashboard/dashboard.module';


@NgModule({
  declarations: [
    TablePageComponent,
    AttacksTableComponent,
    FilterComponent,
  ],
  imports: [
    CommonModule,
    TablesRoutingModule,
    MatCardModule,
    MatIconModule,
    MatMenuModule,
    MatTableModule,
    MatButtonModule,
    MatCheckboxModule,
    MatToolbarModule,
    MatPaginatorModule,
    MatFormFieldModule,
    SharedModule  ,
    MatSortModule,
    AutocompleteLibModule,
    MatAutocompleteModule,
    MatInputModule,
    FormsModule,
    ReactiveFormsModule,
    DashboardModule
  ],
  providers: [
    TableService
  ]
})
export class TablesModule { }

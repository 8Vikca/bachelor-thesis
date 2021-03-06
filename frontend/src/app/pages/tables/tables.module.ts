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
import { SearchBoxComponent } from './components/search-box/search-box.component';


@NgModule({
  declarations: [
    TablePageComponent,
    AttacksTableComponent,
    SearchBoxComponent   
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
    SharedModule   
  ],
  providers: [
    TableService
  ]
})
export class TablesModule { }

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatTableModule } from '@angular/material/table';
import { NgxEchartsModule } from 'ngx-echarts';
import { TrendModule } from 'ngx-trend';
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { MatMenuModule } from '@angular/material/menu';
import { MatButtonModule } from '@angular/material/button';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatSelectModule } from '@angular/material/select';
import { MatInputModule } from '@angular/material/input';
import { NgApexchartsModule } from 'ng-apexcharts';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { DashboardPageComponent, NoDataDialog } from './containers';
import {
  AlertCounterComponent,
  TimelineChartComponent,
  CategoryChartComponent,
  SeverityTableComponent,
  IpChartComponent,
  RecentDataTableComponent,
  
} from './components';
import { SharedModule } from '../../shared/shared.module';
import { DashboardService } from './services';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { MatNativeDateModule } from '@angular/material/core';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatFormFieldModule } from '@angular/material/form-field';
import { Daterangepicker } from 'ng2-daterangepicker';
import { NgxAircalModule } from "ngx-aircal";
import { NgxDaterangepickerMd } from 'ngx-daterangepicker-material';
import { MomentModule } from 'ngx-moment';
import { NgxDaterangePickerComponent } from './components/ngx-daterange-picker/ngx-daterange-picker.component';
import {MatDialogModule} from '@angular/material/dialog';


@NgModule({
  declarations: [
    DashboardPageComponent,
    SeverityTableComponent,
    CategoryChartComponent,
    IpChartComponent,
    RecentDataTableComponent,
    AlertCounterComponent,
    TimelineChartComponent,
    NgxDaterangePickerComponent,
    NoDataDialog
  ],
  imports: [
    CommonModule,
    MatTableModule,
    NgxEchartsModule,
    TrendModule,
    MatCardModule,
    MatIconModule,
    MatMenuModule,
    MatButtonModule,
    MatProgressBarModule,
    MatToolbarModule,
    MatGridListModule,
    MatSelectModule,
    MatInputModule,
    NgApexchartsModule,
    FormsModule,
    SharedModule,
    MatPaginatorModule,
    MatSortModule,
    MatDialogModule,
    MatNativeDateModule,
    MatDatepickerModule,
    MatFormFieldModule,
    ReactiveFormsModule,
    Daterangepicker,
    NgxAircalModule,
    NgxDaterangepickerMd.forRoot(),
    MomentModule
  ],
  exports: [
    NgxDaterangePickerComponent
  ],
  providers: [
    DashboardService,
  ]
})
export class DashboardModule { }

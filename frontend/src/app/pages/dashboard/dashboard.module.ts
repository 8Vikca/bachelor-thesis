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

import { DashboardPageComponent } from './containers';
import {
  VisitsChartComponent,
  PerformanceChartComponent,
  ServerChartComponent,
  RevenueChartComponent,
  DailyLineChartComponent,
  SupportRequestsComponent,
  ProjectStatChartComponent,
  SeverityTableComponent,
  RecentTableComponent,
  DatePickerComponent
} from './components';
import { SharedModule } from '../../shared/shared.module';
import { DashboardService } from './services';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { CategoryChartComponent } from './components/category-chart/category-chart.component';
import { IpChartComponent } from './components/ip-chart/ip-chart.component';
import { MatNativeDateModule } from '@angular/material/core';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatFormFieldModule } from '@angular/material/form-field' 


@NgModule({
  declarations: [
    DashboardPageComponent,
    VisitsChartComponent,
    PerformanceChartComponent,
    ServerChartComponent,
    RevenueChartComponent,
    DailyLineChartComponent,
    SupportRequestsComponent,
    ProjectStatChartComponent,
    RecentTableComponent,
    SeverityTableComponent,
    CategoryChartComponent,
    IpChartComponent,
    DatePickerComponent
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
    MatNativeDateModule,
    MatDatepickerModule,
    MatFormFieldModule
  ],
  exports: [
    DailyLineChartComponent
  ],
  providers: [
    DashboardService
  ]
})
export class DashboardModule { }

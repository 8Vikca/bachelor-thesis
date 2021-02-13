import { AfterViewInit, Component, Input, OnInit, ViewChild } from '@angular/core';
import {animate, state, style, transition, trigger} from '@angular/animations';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable, MatTableDataSource } from '@angular/material/table';
import { Attack } from '../../models';

@Component({
  selector: 'app-recent-table',
  templateUrl: './recent-table.component.html',
  styleUrls: ['./recent-table.component.scss'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class RecentTableComponent implements OnInit { //AfterViewInit
  @Input() recentTableData: Attack[] = [];
  public displayedColumns = ['timestamp', 'message', 'severity'];
  public dataSource: MatTableDataSource<Attack>;
  expandedElement: Attack | null;

  ngOnInit() {
      this.dataSource = new MatTableDataSource<Attack>(this.recentTableData);
  }

  // ngAfterViewInit() {
  //   this.dataSource.sort = this.sort;
  //   this.dataSource.paginator = this.paginator;
  //   this.table.dataSource = this.dataSource;
  // }
}

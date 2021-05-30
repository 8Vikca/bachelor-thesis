import { animate, state, style, transition, trigger } from '@angular/animations';
import { Component, Input, OnChanges, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { Attack } from '../../models';

@Component({
  selector: 'app-recent-data-table',
  templateUrl: './recent-data-table.component.html',
  styleUrls: ['./recent-data-table.component.scss'],
  animations: [   //animacia pre expand tabulky
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class RecentDataTableComponent implements OnInit, OnChanges {
  @Input() recentTableData: Attack[] = [];
  public displayedColumns = ['timestamp', 'message', 'severity'];
  public dataSource: MatTableDataSource<Attack>;
  expandedElement: Attack | null;

  constructor() { 
  }

  ngOnInit() {
      this.dataSource = new MatTableDataSource<Attack>(this.recentTableData);
  }
  ngOnChanges() {
    this.dataSource = new MatTableDataSource<Attack>(this.recentTableData);
  }
}



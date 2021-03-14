import { animate, state, style, transition, trigger } from '@angular/animations';
import { Component, Input, OnChanges, OnInit } from '@angular/core';

import { MatTableDataSource } from '@angular/material/table';
import { Attack } from '../../models';

@Component({
  selector: 'app-severity-table',
  templateUrl: './severity-table.component.html',
  styleUrls: ['./severity-table.component.scss'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})

export class SeverityTableComponent implements OnInit, OnChanges {
  @Input() severityTableData: Attack[] = [];
  public displayedColumns = ['timestamp', 'message', 'severity'];
  public dataSource: MatTableDataSource<Attack>;
  expandedElement: Attack | null;

  ngOnInit() {
      this.dataSource = new MatTableDataSource<Attack>(this.severityTableData);
  }
  ngOnChanges() {
    this.dataSource = new MatTableDataSource<Attack>(this.severityTableData);
    debugger
  }


}


import { AfterViewInit, Component, Input, OnInit, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { SelectionModel } from '@angular/cdk/collections';
import { MatPaginator } from '@angular/material/paginator';
import { Attack } from '../../models/attack';
import { MatSort } from '@angular/material/sort';


@Component({
  selector: 'app-attacks-table',
  templateUrl: './attacks-table.component.html',
  styleUrls: ['./attacks-table.component.scss']
})
export class AttacksTableComponent implements OnInit, AfterViewInit {
  @Input() employeeTableData: Attack[] = [];
  public displayedColumns: string[] = ['timestamp', 'message', 'severity', 'proto', 'src_ip', 'dest_ip'];
  public dataSource: MatTableDataSource<Attack>;
  public selection = new SelectionModel<Attack>(true, []);

  public isShowFilterInput = false;

  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  constructor() {

  }
  ngAfterViewInit(): void {
    this.dataSource.sort = this.sort;
  }

  public ngOnInit(): void {
    this.dataSource = new MatTableDataSource<Attack>(this.employeeTableData);
    this.dataSource.paginator = this.paginator;
  }
  ngOnChanges() {
    this.dataSource = new MatTableDataSource<Attack>(this.employeeTableData);
    this.dataSource.paginator = this.paginator;
  }
}

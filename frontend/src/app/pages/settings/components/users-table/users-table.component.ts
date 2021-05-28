import { Component, EventEmitter, Input, OnChanges, OnInit, Output, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { User } from 'src/app/pages/auth/models';
import { SettingsService } from '../../services/settings.service';

@Component({
  selector: 'app-users-table',
  templateUrl: './users-table.component.html',
  styleUrls: ['./users-table.component.scss']
})
export class UsersTableComponent implements OnInit, OnChanges {
  @Input() usersTableData: User[] = [];
  @Output() userEmitter = new EventEmitter<any>();
  public displayedColumns = ['id', 'email', 'firstname', 'lastname', 'role', 'actions'];
  public dataSource: MatTableDataSource<User>;
  index: number;
  id: number;

  constructor(public dialog: MatDialog, private service: SettingsService, private _snackBar: MatSnackBar) {
  }
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: true }) sort: MatSort;

  ngAfterViewInit(): void {
    this.dataSource.sort = this.sort;
  }

  ngOnInit() {
    this.dataSource = new MatTableDataSource<User>(this.usersTableData);
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }
  ngOnChanges() {
    this.dataSource = new MatTableDataSource<User>(this.usersTableData);
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  deleteUser(userId: number) {
    this.service.deleteUser(userId).subscribe(response => {
      if (response.status == 200) {
        let snackBarRef = this._snackBar.open('User deleted', null, {
          duration: 2500,
          horizontalPosition: 'center',
          verticalPosition: 'top',
          panelClass: ['snackbar']
        });
        this.refreshTable();
      }
    },
    );
  }

  private refreshTable() {
    this.paginator._changePageSize(this.paginator.pageSize);
  }
}
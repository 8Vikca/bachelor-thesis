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
      (err) => {
        let snackBarRef = this._snackBar.open('{{err}}', null, {
          duration: 2500,
          horizontalPosition: 'center',
          verticalPosition: 'top',
          panelClass: ['snackbar']
        });
      });
  }

  private refreshTable() {
    this.paginator._changePageSize(this.paginator.pageSize);
  }
}



  //   filteredData: Issue[] = [];
  //   renderedData: Issue[] = [];

  //   constructor(public _exampleDatabase: DataService,
  //               public _paginator: MatPaginator,
  //               public _sort: MatSort) {
  //     super();
  //     // Reset to the first page when the user changes the filter.
  //     this._filterChange.subscribe(() => this._paginator.pageIndex = 0);
  //   }

  //   /** Connect function called by the table to retrieve one stream containing the data to render. */
  //   connect(): Observable<Issue[]> {
  //     // Listen for any changes in the base data, sorting, filtering, or pagination
  //     const displayDataChanges = [
  //       this._exampleDatabase.dataChange,
  //       this._sort.sortChange,
  //       this._filterChange,
  //       this._paginator.page
  //     ];

  //     this._exampleDatabase.getAllIssues();


  //     return merge(...displayDataChanges).pipe(map( () => {
  //         // Filter data
  //         this.filteredData = this._exampleDatabase.data.slice().filter((issue: Issue) => {
  //           const searchStr = (issue.id + issue.title + issue.url + issue.created_at).toLowerCase();
  //           return searchStr.indexOf(this.filter.toLowerCase()) !== -1;
  //         });

  //         // Sort filtered data
  //         const sortedData = this.sortData(this.filteredData.slice());

  //         // Grab the page's slice of the filtered sorted data.
  //         const startIndex = this._paginator.pageIndex * this._paginator.pageSize;
  //         this.renderedData = sortedData.splice(startIndex, this._paginator.pageSize);
  //         return this.renderedData;
  //       }
  //     ));
  //   }

  //   disconnect() {}




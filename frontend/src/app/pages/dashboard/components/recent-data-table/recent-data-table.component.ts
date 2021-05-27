import { animate, state, style, transition, trigger } from '@angular/animations';
import { AfterViewInit, ChangeDetectorRef, Component, Input, OnChanges, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatTableDataSource } from '@angular/material/table';
import { Attack } from '../../models';

@Component({
  selector: 'app-recent-data-table',
  templateUrl: './recent-data-table.component.html',
  styleUrls: ['./recent-data-table.component.scss'],
  animations: [
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

  constructor(private _snackBar: MatSnackBar) { 
  }

  ngOnInit() {
      this.dataSource = new MatTableDataSource<Attack>(this.recentTableData);
      // if (this.recentTableData.length == 0) {
      //   let snackBarRef = this._snackBar.open('No data to show', null, {
      //     duration: 2500,
      //     horizontalPosition: 'center',
      //     verticalPosition: 'top',
      //     panelClass: ['snackbar']
      //   });
      // }
  }
  ngOnChanges() {
    this.dataSource = new MatTableDataSource<Attack>(this.recentTableData);
    // if (this.recentTableData.length == 0) {
    //   let snackBarRef = this._snackBar.open('No data to show', null, {
    //     duration: 2500,
    //     horizontalPosition: 'center',
    //     verticalPosition: 'top',
    //     panelClass: ['snackbar']
    //   });
    // }
  }

}



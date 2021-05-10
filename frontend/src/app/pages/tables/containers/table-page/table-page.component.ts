import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { TableService } from '../../services';
import { Attack } from '../../models';
import { HttpParams } from '@angular/common/http';
import { MatSnackBar } from '@angular/material/snack-bar';


@Component({
  selector: 'app-table-page',
  templateUrl: './table-page.component.html',
  styleUrls: ['./table-page.component.scss']
})
export class TablePageComponent implements OnInit {
  public tableData: Attack[] = [];
  params: HttpParams;


  constructor(private service: TableService, private _snackBar: MatSnackBar) {
  }

  public ngOnInit() {
    this.getData();
    //this.getFilteredData(this.params);
  }

  getData(): void {
    this.service.loadAllTableData()
      .subscribe(result => {
        this.tableData = result;
      });
  }
  getFilteredData(params: HttpParams): void {
    this.service.loadFilteredData(params)
      .subscribe(result => {
        this.tableData = result;
      });

  }

  public sendFilters(event: any): void {
    if (event.startDate == "" || event.endDate == "") {
      this.getData();
    }
    this.params = new HttpParams();
    this.params = this.params.set("startDate", event.startDate).set("endDate", event.endDate);
    event.filters.forEach(element => {
      this.params = this.params.append('filter', element);
    });
    this.getFilteredData(this.params);
    debugger
    if (this.tableData.length == 0) {
        let snackBarRef = this._snackBar.open('No data to show', null, {
          duration: 2500,
          horizontalPosition: 'center',
          verticalPosition: 'top',
          panelClass: ['snackbar']
        });
      }
  }
};






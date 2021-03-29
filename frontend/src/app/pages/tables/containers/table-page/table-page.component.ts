import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { TableService } from '../../services';
import { Attack } from '../../models';
import { HttpParams } from '@angular/common/http';
import { ITS_JUST_ANGULAR } from '@angular/core/src/r3_symbols';


@Component({
  selector: 'app-table-page',
  templateUrl: './table-page.component.html',
  styleUrls: ['./table-page.component.scss']
})
export class TablePageComponent implements OnInit {
  public employeeTableData: Attack[];  
  params = new HttpParams();

  constructor(private service: TableService) {
  }

  public ngOnInit() {
    this.getData();
  }

  getData(): void {
    this.service.loadAllTableData()
      .subscribe(result => {
        this.employeeTableData = result;
      });
  }
  getFilteredData(params: HttpParams): void {
    debugger
    this.service.loadFilteredData(params)
      .subscribe(result => {
        this.employeeTableData = result;
      });

  }

  public sendFilters(event: any): void {
    event.forEach(element => {
      this.params= this.params.append('filter', element);
    });
    this.getFilteredData(this.params);
  }
};






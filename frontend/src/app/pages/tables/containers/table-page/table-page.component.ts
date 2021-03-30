import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { TableService } from '../../services';
import { Attack } from '../../models';
import { HttpParams } from '@angular/common/http';


@Component({
  selector: 'app-table-page',
  templateUrl: './table-page.component.html',
  styleUrls: ['./table-page.component.scss']
})
export class TablePageComponent implements OnInit {
  public employeeTableData: Attack[];  
  params: HttpParams;

  constructor(private service: TableService) {
  }

  public ngOnInit() {
    //this.getData();
    this.getFilteredData(this.params);
  }

  getData(): void {
    this.service.loadAllTableData()
      .subscribe(result => {
        this.employeeTableData = result;
      });
  }
  getFilteredData(params: HttpParams): void {
    this.service.loadFilteredData(params)
      .subscribe(result => {
        this.employeeTableData = result;
      });

  }

  public sendFilters(event: any): void {
    this.params = new HttpParams();
    event.forEach(element => {
      this.params= this.params.append('filter', element);
    });
    this.getFilteredData(this.params);
  }
};






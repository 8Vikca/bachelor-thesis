import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { TableService } from '../../services';
import { Attack } from '../../models';


@Component({
  selector: 'app-table-page',
  templateUrl: './table-page.component.html',
  styleUrls: ['./table-page.component.scss']
})
export class TablePageComponent implements OnInit {
  public employeeTableData: Attack[] = [];   //Observable<Attack[]>
  public parentDataLoaded: boolean = false;

  constructor(private service: TableService) {
  }

  public ngOnInit() {
    this.service.loadEmployeeTableData().subscribe(result => {
      this.employeeTableData= result;
      this.parentDataLoaded = true;
      });

    }
};






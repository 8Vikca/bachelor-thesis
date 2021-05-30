import { Component, ElementRef, EventEmitter, OnInit, Output, ViewChild } from '@angular/core';
import { FormControl } from '@angular/forms';
import { AircalResponse } from 'ngx-aircal';
import { Observable } from 'rxjs';
import { map, startWith } from 'rxjs/operators';

@Component({
  selector: 'app-filter',
  templateUrl: './filter.component.html',
  styleUrls: ['./filter.component.scss']
})
export class FilterComponent implements OnInit {
  removable = true;
  visible = true;
  queryInput: string = "";
  filters: string[] = [];
  @ViewChild('searchInput') filterInput: ElementRef;
  @Output() filterEmitter = new EventEmitter<{ startDate: string, endDate: string, filters: string[] }>();
  startDate: string = "";
  endDate: string = "";

  constructor() { }

  ngOnInit(): void {
    this.filteredOptions = this.myControl.valueChanges
      .pipe(
        startWith(''),
        map(value => this._filter(value))
      );

  }
  myControl = new FormControl();
  options: string[] = ['Category = ', 'Severity = ', 'Protocol = ', 'Source_ip = ', 'Dest_ip = '];
  filteredOptions: Observable<string[]>;

  private _filter(value: string): string[] {
    const filterValue = value.toLowerCase();

    return this.options.filter(option => option.toLowerCase().includes(filterValue));
  }


  public addFilter(queryInput: any): void {       //pridat filter
    this.filters.push(queryInput);
    this.queryInput = '';
  }

  public sendFilters(): void {        //odoslat filtre
    this.filterEmitter.emit({ startDate: this.startDate, endDate: this.endDate, filters: this.filters });
  }
  public clearFilters(): void {       //vymazat vsetky filtre
    console.log(this.filters);
    this.filters.splice(0, this.filters.length);
    this.sendFilters();

  }
  public clearOneFilter(index: any): void {     //vymazat urcity filter
    this.filters.splice(index, 1);
  }

  public pushDates(event: AircalResponse): void {       //filtrovat podla datumu
    this.startDate = event.startDate.toISOString();
    this.endDate = event.endDate.toISOString();
  }
}

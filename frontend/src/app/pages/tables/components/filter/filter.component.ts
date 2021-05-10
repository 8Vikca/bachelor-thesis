import { stringify } from '@angular/compiler/src/util';
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
  @Output() filterEmitter = new EventEmitter<{startDate: string , endDate: string, filters: string[]}>();
  startDate: string = "";
  endDate: string = "";
  openCalendar= false;
  
  constructor() { }

  ngOnInit(): void {
    this.filteredOptions = this.myControl.valueChanges
      .pipe(
        startWith(''),
        map(value => this._filter(value))
      );

  }
  myControl = new FormControl();
  options: string[] = ['Category = ', 'Severity = ', 'Protocol = ', 'Source_IP = ', 'Dest_IP = '];
  filteredOptions: Observable<string[]>;
  
  private _filter(value: string): string[] {
    const filterValue = value.toLowerCase();

    return this.options.filter(option => option.toLowerCase().includes(filterValue));
  }
  public openChild(){
    this.openCalendar = true;
  }

  public addFilter(queryInput:any): void {
    this.filters.push(queryInput);
    this.queryInput = '';
  }

  public sendFilters(): void {
    this.filterEmitter.emit({startDate: this.startDate, endDate: this.endDate, filters: this.filters});
  }
  public clearFilters(): void {
    console.log(this.filters);
    this.filters.splice(0, this.filters.length);
    this.startDate = "";
    this.endDate = "";
    this.sendFilters();

  }  
  public clearOneFilter(index: any): void {
      this.filters.splice(index,1);
  }
  
  public pushDates(event: AircalResponse): void {
    this.startDate = event.startDate.toISOString();
    this.endDate = event.endDate.toISOString();
}


  // selectEvent(item) {
  //   // do something with selected item
  // }

  // onChangeSearch(val: string) {
  //   // fetch remote data from here
  //   // And reassign the 'data' which is binded to 'data' property.
  // }
  
  // onFocused(e){
  //   // do something when input is focused
  // }
}

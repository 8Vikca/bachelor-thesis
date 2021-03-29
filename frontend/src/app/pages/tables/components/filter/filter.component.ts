import { Component, ElementRef, EventEmitter, OnInit, Output, ViewChild } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Observable } from 'rxjs';
import { map, startWith } from 'rxjs/operators';

@Component({
  selector: 'app-filter',
  templateUrl: './filter.component.html',
  styleUrls: ['./filter.component.scss']
})
export class FilterComponent implements OnInit {
  queryInput: string = "";
  filters: string[] = [];
  @ViewChild('searchInput') filterInput: ElementRef;
  @Output() filterEmitter = new EventEmitter<any>();
  
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

  public addFilter(queryInput:any): void {
    this.filters.push(queryInput);
    this.queryInput = '';
  }

  public sendFilters(): void {
    this.filterEmitter.emit(this.filters);
  }
  
  
  
  
  // Filter = "Filter...";
  // keyword = 'name';
  // data = [
  //    {
  //      id: 1,
  //      name: 'Category = '
  //    },
  //    {
  //      id: 2,
  //      name: 'Severity = '
  //    },
  //    {
  //     id: 3,
  //     name: 'Protocol = '
  //   },
  //   {
  //     id: 4,
  //     name: 'Source_IP = '
  //   },
  //   {
  //     id: 5,
  //     name: 'Dest_IP = '
  //   }
  // ];


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

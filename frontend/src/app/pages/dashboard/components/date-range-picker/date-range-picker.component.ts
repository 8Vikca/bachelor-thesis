import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-date-range-picker',
  templateUrl: './date-range-picker.component.html',
  styleUrls: ['./date-range-picker.component.css']
})
export class DateRangePickerComponent implements OnInit {
  @Output() dateEmitter = new EventEmitter<any>();
  constructor() { }

  ngOnInit(): void {
    
  }
  dateChange(event: any) {
      console.log('changed' + event);
      this.dateEmitter.emit(event);
  }
}

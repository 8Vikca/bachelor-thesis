import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import * as moment from 'moment';

@Component({
  selector: 'app-ngx-daterange-picker',
  templateUrl: './ngx-daterange-picker.component.html',
  styleUrls: ['./ngx-daterange-picker.component.scss']
})
export class NgxDaterangePickerComponent {
  @Output() dateEmitter = new EventEmitter<any>();
  dateRangeFired:boolean;
  selected: any;
  alwaysShowCalendars: boolean;
  ranges: any = {
    'Today': [moment().set({ hours: 0, minutes: 0 }), moment().set({ hours: 23, minutes: 59 })],
    'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
    'Last 7 Days': [moment().subtract(6, 'days'), moment()],
    'Last 30 Days': [moment().subtract(29, 'days'), moment()],
    'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')],
    'Last Year': [moment().subtract(1, 'years'), moment()],
  }
  autoApply: any;


  constructor() {
    this.alwaysShowCalendars = true;
    this.autoApply = true;
    this.selected = {
      startDate: moment().set({ hours: 0, minutes: 0, seconds: 0, milliseconds: 0 }),
      endDate: moment().set({ hours: 23, minutes: 59, seconds: 59, milliseconds: 999 })
    };
  }
  

  public datesUpdated(event: any) {
    // debugger
    // if (this.dateRangeFired == true) {
    //   this.dateRangeFired = false;
    //   return;
    // }
    // this.dateRangeFired = true;
    // debugger
    if (event.startDate === null) {
      event.startDate = moment().set({ hours: 0, minutes: 0, seconds: 0, milliseconds: 0 });
      event.endDate = moment().set({ hours: 23, minutes: 59, seconds: 59, milliseconds: 999 });
    }
    this.dateEmitter.emit(event);
  }
}


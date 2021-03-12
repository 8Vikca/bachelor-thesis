import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { AircalOptions, AircalResponse } from 'ngx-aircal';

@Component({
  selector: 'app-date-picker-aircal',
  templateUrl: './date-picker-aircal.component.html',
  styleUrls: ['./date-picker-aircal.component.scss']
})
export class DatePickerAircalComponent implements OnInit {
  // dateRange = new FormGroup({
  //   startDate: new FormControl(),
  //   endDate: new FormControl(),
  // })
   today= new Date();
  @Output() dateEmitter = new EventEmitter<any>();
  public calendarOptions: AircalOptions = new AircalOptions({
    inlineMode: false,
    daysSelectedCounterVisible: false,
    singlePicker: true,
    autoApplyAndClose:false,
    showApplyBtn: true,
    autoCloseWhenApplied: true,
    highlightToday:true, 
    allowUserInputField:true,
    closeOnOutsideClick:true,
    arrowBias: 'left',
    selectionShortcutVisible: true,
    selectionShortcuts: { "0.days": "Today", "-1.days": "Yesterday", "1.months": "Last Week", "6.months": "Last Month"},
    startDate: new Date(),  //(this.today.setDate(this.today.getDate()-1)
    endDate: new Date()   
  });
  constructor() { }

  ngOnInit(): void {
    
  }

  public onDateRangeChanged(event: AircalResponse) {
    this.dateEmitter.emit(event);
    
  }

}

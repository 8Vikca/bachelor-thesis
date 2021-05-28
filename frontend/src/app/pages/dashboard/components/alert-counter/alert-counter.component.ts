import { Component, Input, OnInit } from '@angular/core';
import { Counter } from '../../models';

@Component({
  selector: 'app-alert-counter',
  templateUrl: './alert-counter.component.html',
  styleUrls: ['./alert-counter.component.scss']
})
export class AlertCounterComponent implements OnInit {
  @Input() alertCounters: Counter = {
    alertsCritical: 0, alertsHigh: 0, alertsLow: 0, alertsMedium: 0, alertsTotal: 0,
  };
  constructor() { 
  }

  ngOnInit(): void {
  }

}

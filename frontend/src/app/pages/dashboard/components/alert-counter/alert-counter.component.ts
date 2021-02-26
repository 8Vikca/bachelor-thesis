import { NullTemplateVisitor } from '@angular/compiler';
import { Component, Input, OnInit } from '@angular/core';
import { Counter } from '../../models';

@Component({
  selector: 'app-alert-counter',
  templateUrl: './alert-counter.component.html',
  styleUrls: ['./alert-counter.component.scss']
})
export class AlertCounterComponent implements OnInit {
  @Input() alertCounters: Counter = {
    counterSrc : null,
    labelSrc : null,
    alertsCritical: null, alertsHigh: null, alertsLow: null, alertsMedium: null, alertsTotal: null,
  };
  constructor() { }

  ngOnInit(): void {
  }

}

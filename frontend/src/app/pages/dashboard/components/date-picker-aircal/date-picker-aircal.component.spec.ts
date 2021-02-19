import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DatePickerAircalComponent } from './date-picker-aircal.component';

describe('DatePickerAircalComponent', () => {
  let component: DatePickerAircalComponent;
  let fixture: ComponentFixture<DatePickerAircalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DatePickerAircalComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DatePickerAircalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NgxDaterangePickerComponent } from './ngx-daterange-picker.component';

describe('NgxDaterangePickerComponent', () => {
  let component: NgxDaterangePickerComponent;
  let fixture: ComponentFixture<NgxDaterangePickerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NgxDaterangePickerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NgxDaterangePickerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

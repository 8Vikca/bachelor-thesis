import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AlertCounterComponent } from './alert-counter.component';

describe('AlertCounterComponent', () => {
  let component: AlertCounterComponent;
  let fixture: ComponentFixture<AlertCounterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AlertCounterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AlertCounterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

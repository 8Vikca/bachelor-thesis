import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { IpChartComponent } from './ip-chart.component';

describe('IpChartComponent', () => {
  let component: IpChartComponent;
  let fixture: ComponentFixture<IpChartComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ IpChartComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(IpChartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

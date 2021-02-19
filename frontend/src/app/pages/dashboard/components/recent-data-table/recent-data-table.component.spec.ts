import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecentDataTableComponent } from './recent-data-table.component';

describe('RecentDataTableComponent', () => {
  let component: RecentDataTableComponent;
  let fixture: ComponentFixture<RecentDataTableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RecentDataTableComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RecentDataTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

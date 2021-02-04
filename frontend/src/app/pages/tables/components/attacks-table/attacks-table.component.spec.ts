import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AttacksTableComponent } from './attacks-table.component';

describe('AttacksTableComponent', () => {
  let component: AttacksTableComponent;
  let fixture: ComponentFixture<AttacksTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AttacksTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AttacksTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

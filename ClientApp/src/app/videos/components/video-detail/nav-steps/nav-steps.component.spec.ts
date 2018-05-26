import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NavStepsComponent } from './nav-steps.component';

describe('NavStepsComponent', () => {
  let component: NavStepsComponent;
  let fixture: ComponentFixture<NavStepsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NavStepsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NavStepsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

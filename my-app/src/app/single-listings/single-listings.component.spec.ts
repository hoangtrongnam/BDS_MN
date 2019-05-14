import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SingleListingsComponent } from './single-listings.component';

describe('SingleListingsComponent', () => {
  let component: SingleListingsComponent;
  let fixture: ComponentFixture<SingleListingsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SingleListingsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SingleListingsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

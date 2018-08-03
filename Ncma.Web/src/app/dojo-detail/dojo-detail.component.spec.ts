import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DojoDetailComponent } from './dojo-detail.component';

describe('DojoDetailComponent', () => {
  let component: DojoDetailComponent;
  let fixture: ComponentFixture<DojoDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DojoDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DojoDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

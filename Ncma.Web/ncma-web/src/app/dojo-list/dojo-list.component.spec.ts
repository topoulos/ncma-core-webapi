import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DojoListComponent } from './dojo-list.component';

describe('DojoListComponent', () => {
  let component: DojoListComponent;
  let fixture: ComponentFixture<DojoListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DojoListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DojoListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewCustomlistComponent } from './new-customlist.component';

describe('NewCustomlistComponent', () => {
  let component: NewCustomlistComponent;
  let fixture: ComponentFixture<NewCustomlistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewCustomlistComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NewCustomlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

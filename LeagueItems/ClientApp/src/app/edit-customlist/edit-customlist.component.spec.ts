import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditCustomlistComponent } from './edit-customlist.component';

describe('EditCustomlistComponent', () => {
  let component: EditCustomlistComponent;
  let fixture: ComponentFixture<EditCustomlistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditCustomlistComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditCustomlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

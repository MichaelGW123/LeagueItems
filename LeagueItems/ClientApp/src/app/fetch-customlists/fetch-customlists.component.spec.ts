import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FetchCustomlistsComponent } from './fetch-customlists.component';

describe('FetchCustomlistsComponent', () => {
  let component: FetchCustomlistsComponent;
  let fixture: ComponentFixture<FetchCustomlistsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FetchCustomlistsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FetchCustomlistsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

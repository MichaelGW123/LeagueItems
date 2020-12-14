import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FetchChampionsComponent } from './fetch-champions.component';

describe('FetchChampionsComponent', () => {
  let component: FetchChampionsComponent;
  let fixture: ComponentFixture<FetchChampionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FetchChampionsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FetchChampionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

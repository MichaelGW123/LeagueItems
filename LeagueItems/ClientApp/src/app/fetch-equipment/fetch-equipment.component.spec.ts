import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FetchEquipmentComponent } from './fetch-equipment.component';

describe('FetchEquipmentComponent', () => {
  let component: FetchEquipmentComponent;
  let fixture: ComponentFixture<FetchEquipmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FetchEquipmentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FetchEquipmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

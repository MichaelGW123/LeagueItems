import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';

@Component({
  selector: 'app-fetch-equipment',
  templateUrl: './fetch-equipment.component.html',
  styleUrls: ['./fetch-equipment.component.css']
})
export class FetchEquipmentComponent implements OnInit {
  equipments: Equipment[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Equipment[]>(baseUrl + 'api/Equipments').subscribe(result => {
      this.equipments = result;
    }, error => console.error(error));
  }

  ngOnInit(): void {
  }

}

interface Equipment {
  equipmentId: number;
  name: string;
  description: string;
  stats: string;
  cost: number;
}

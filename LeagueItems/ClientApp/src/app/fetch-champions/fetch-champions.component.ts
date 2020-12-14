import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';

@Component({
  selector: 'app-fetch-champions',
  templateUrl: './fetch-champions.component.html',
  styleUrls: ['./fetch-champions.component.css']
})
export class FetchChampionsComponent implements OnInit {
  public champions: Champion[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Champion[]>(baseUrl + 'api/Champions').subscribe(result => {
      this.champions = result;
    }, error => console.error(error));
  }

  ngOnInit(): void {
  }

}

interface Champion {
  championId: number;
  name: string;
  description: string;
  attacktype: string;
  damagetype: string;
}

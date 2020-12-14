import { HttpClient } from '@angular/common/http';
import { Component, Inject, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-fetch-customlists',
  templateUrl: './fetch-customlists.component.html',
  styleUrls: ['./fetch-customlists.component.css']
})
export class FetchCustomlistsComponent implements OnInit {
  public customLists: ViewCustomList[];
  @Input() customList: ViewCustomList;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<ViewCustomList[]>(baseUrl + 'api/CustomLists').subscribe(result => {
      this.customLists = result;
    }, error => console.error(error));
  }

  ngOnInit(): void {
  }


}

interface ViewCustomList {
  listId: number;
  name: string;
  championName: string;
  equipmentName1: string;
  equipmentName2: string;
  equipmentName3: string;
  equipmentName4: string;
  equipmentName5: string;
  equipmentName6: string;
}

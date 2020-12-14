import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit, Input } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-edit-customlist',
  templateUrl: './edit-customlist.component.html',
  styleUrls: ['./edit-customlist.component.css']
})
export class EditCustomlistComponent implements OnInit {
  customList: ViewCustomList;
  equipName1: string = "";
  equipName2: string = "";
  equipName3: string = "";
  equipName4: string = "";
  equipName5: string = "";
  equipName6: string = "";
  base: string = "";
  http: HttpClient;

  constructor(private route: ActivatedRoute, private router: Router, http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.base = baseUrl;
    this.http = http;
  }

  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id')!;
    this.http.get<ViewCustomList>(this.base + `api/CustomLists/${id}`).subscribe(result => {
      this.customList = result;
      this.equipName1 = result.equipmentName1;
      this.equipName2 = result.equipmentName2;
      this.equipName3 = result.equipmentName3;
      this.equipName4 = result.equipmentName4;
      this.equipName5 = result.equipmentName5;
      this.equipName6 = result.equipmentName6;
    }, error => console.error(error));
  }

  deleteCustomList(): void {
    alert('Deleting this custom list.');
    this.http.delete(this.base + `api/CustomLists/${this.customList.listId.toString()}`).subscribe();
    this.router.navigateByUrl('');
  }

  saveCustomList(): void {
    alert('Saving changes to this custom list.');
    const body = { listId: this.customList.listId, name: this.customList.name, championName: this.customList.championName, equipmentName1: this.equipName1, equipmentName2: this.equipName2, equipmentName3: this.equipName3, equipmentName4: this.equipName4, equipmentName5: this.equipName5, equipmentName6: this.equipName6,};
    this.http.put<any>(this.base + `api/CustomLists/${this.customList.listId.toString()}`, body).subscribe();
    this.router.navigateByUrl('');
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

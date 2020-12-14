import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-new-customlist',
  templateUrl: './new-customlist.component.html',
  styleUrls: ['./new-customlist.component.css']
})
export class NewCustomlistComponent implements OnInit {
  name: string = '';
  championName: string = '';
  base: string = "";
  http: HttpClient;

  constructor(private router: Router, http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.base = baseUrl;
    this.http = http;
  }

  ngOnInit(): void {
  }

  onSubmit(): void {
    if (!this.name || 0 === this.name.length || !this.championName || 0 === this.championName.length) {
      alert('You need to fill in all the information.');
    } else {
      alert('Creating a new Custom List.');
      const body = { name: this.name, userId: 50, championName: this.championName };
      this.http.post<any>(this.base + 'api/CustomLists', body).subscribe();
      this.router.navigateByUrl('');
    }
  }
}

import { Component } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/auth';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  constructor(private auth: AngularFireAuth, private router: Router) {

  }

  ngOnInit() { }

  onLogout() {
    this.auth.signOut().then(() => this.router.navigate(['login']));
  }
}

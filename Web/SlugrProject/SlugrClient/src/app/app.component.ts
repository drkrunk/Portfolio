import { Component } from '@angular/core';
import { AuthService } from './auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'slugrClient2';
  userId = Number(localStorage.getItem('userId'));

  constructor(private _authService: AuthService){}

}

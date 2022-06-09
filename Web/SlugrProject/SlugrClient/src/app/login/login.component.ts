import { Component, OnInit } from '@angular/core';
import { AuthService } from '../auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  loginUserData = {};
  constructor(private _auth: AuthService, private _router: Router) { }

  ngOnInit() {}

  loginUser() {
    this._auth.loginUser(this.loginUserData).subscribe(res => this.onLogin(res), err => this.onLoginFailed(err))
  }

  private onLogin(res:any){
    localStorage.setItem('token', res.Authorization)
    localStorage.setItem('userId', res.userID)
    this._router.navigate(['/dashboard/public_projects']);
  }

  private onLoginFailed(err:any){
    console.error(err);
    this.loginUserData = {};
  }

  testResetPassword(){
    this._auth.resetPassword("testset@yahoo.com").subscribe(res=>console.log(res), err=>console.log(err))
  }
}

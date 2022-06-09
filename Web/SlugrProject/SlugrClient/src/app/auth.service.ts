import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http'
import { Observable } from 'rxjs';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private _registerUrl ="http://localhost:9000/api/register";
  private _loginUrl ="http://localhost:9000/login";
  private _refreshUrl ="http://localhost:9000/api/refresh";
  private _resetPasswordUrl = "http://localhost:9000/api/reset-password";

  constructor(private http: HttpClient, private _router: Router) { }

  registerUser(user){
    console.log(user);
    return this.http.post<any>(this._registerUrl, user);
  }

  loginUser(user){
    console.log(user);
    return this.http.post<any>(this._loginUrl, user);
  }


  logoutUser(){
    localStorage.removeItem('token');
    this._router.navigate(['/login']);
  }

  loggedIn(){
    return !!localStorage.getItem('token')
  }

  getToken(){
    return localStorage.getItem('token');
  }

  refreshToken(){
     this.http.get<any>(this._refreshUrl).subscribe(
        res => {localStorage.setItem('token', res.Authorization)},
        err => {console.log(err)}
     )
  }

  resetPassword(email:string){
    return this.http.post<any>(this._resetPasswordUrl, email);
  }

}

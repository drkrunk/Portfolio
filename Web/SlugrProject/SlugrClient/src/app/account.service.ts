import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  private _url ="http://localhost:9000/api/";
  constructor(private http: HttpClient) { }

  getPins(){
    return this.http.get<any>(this._url + "pins");
  }

  getBio(){}
}

import { Injectable, Injector } from '@angular/core';
import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent } from '@angular/common/http';
import { Observable } from 'rxjs';
import {AuthService} from './auth.service';



@Injectable({
  providedIn: 'root'
})

export class TokenInterceptorService implements HttpInterceptor{

  constructor(private injector: Injector) { }
  

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    //return next.handle(this.addAuthHeader(request));
    return next.handle(this.addAuthHeader(request));
    
  }

  addAuthHeader(request):any{
    let authService = this.injector.get(AuthService);
    let token = authService.getToken();

    if(this.tokenExpired(token))authService.refreshToken();

    let authRequest = request.clone({setHeaders:{Authorization: `Bearer ${token} `}});
    return (authService.loggedIn())? authRequest:request;

  }

  private tokenExpired(token: string) {
    if(token==null)return
    const expiry = (JSON.parse(atob(token.split('.')[1]))).exp;
    return (Math.floor((new Date).getTime() / 1000)) >= expiry;
  }
}

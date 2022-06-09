import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Ticket } from './models/ticket';

@Injectable({
  providedIn: 'root'
})
export class TicketService {
  private _url = "http://localhost:9000/api/ticket";

  constructor(private http: HttpClient) { }

  newTicket(ticket, project) {

    let res = { ticket: ticket, project: project };
    console.log(res);
    return this.http.post<any>(this._url + "/submit", res);
  }

  completeTicket(ticket:Ticket){
    return this.http.post<any>(this._url + "/complete", ticket);
  }

  deleteTicket(ticket) {
    return this.http.post<any>(this._url + "/delete", ticket);
  }

  getTicket(id) {
    return this.http.get<Ticket>(this._url + "/" + id)
  }

  getUpdate(ticket: Ticket) {
    return this.http.post<Ticket>(this._url + "/update/", ticket)
  }

  saveTicket(ticket: Ticket) {
    return this.http.post<Ticket>(this._url + "/save", ticket)
  }

  pinTicket(ticket: Ticket){
    return this.http.post<Ticket>(this._url + "/pin", ticket)
  }

  unpinTicket(ticket: Ticket){
    return this.http.post<Ticket>(this._url + "/unpin", ticket)
  }
}

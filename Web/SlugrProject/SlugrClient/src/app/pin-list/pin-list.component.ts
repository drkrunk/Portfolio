
import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { AccountService } from '../account.service';
import { Ticket } from '../models/ticket';
import { TicketService } from '../ticket.service';

@Component({
  selector: 'app-pin-list',
  templateUrl: './pin-list.component.html',
  styleUrls: ['./pin-list.component.css']
})
export class PinListComponent{
  private pins:Array<Ticket>;

  constructor(private changeDetector: ChangeDetectorRef, private _ticketService:TicketService, private _accountService: AccountService, private route: ActivatedRoute, private router: Router) {
    this.updatePinsList();
    this.pins = [];
  }

  goToTicket(item: Ticket) {
    this.router.navigate(['dashboard/ticket', item.id], { relativeTo: this.route.parent, queryParams: { id: item.id } });
  }

  onUnpin(pin:Ticket){
    this._ticketService.unpinTicket(pin).subscribe(res=>this.updatePinsList());
  }

  updatePinsList(){
    this._accountService.getPins().subscribe(
      res => { this.pins = res; this.changeDetector.detectChanges();},
      err => { console.error(err); }
    );
    
  }

}
import { Component, OnInit, OnDestroy, ChangeDetectorRef } from '@angular/core';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { NgbDate } from '@ng-bootstrap/ng-bootstrap';
import { ProjectService } from '../project.service';
import { TicketService } from '../ticket.service';
import { Ticket } from '../models/ticket';
import { Project } from '../models/project';
import { Tag } from '../models/tag';

@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.scss']
})

export class ProjectComponent {

  private project: Project;
  private projectId;
  private tickets;
  private newTicket: Ticket;
  private isOwner: boolean;
  private chips: Array<string> = [];

  private filterExpired;
  private filterClosed;
  private filterEsculated;
  private filterSuspended;


  constructor(private _ticketService: TicketService, private _projectService: ProjectService, private route: ActivatedRoute, private router: Router, private changeDetector: ChangeDetectorRef) {
    this.route.queryParams.subscribe(data => { this.projectId = data.id; this.updateProject(); });
    this.tickets = [];
    this.newTicket = new Ticket();
    this.isOwner = false;
  }

  getExpiredColor(ticket: Ticket): string {
    if (ticket.expirationDate === null) return "";

    const dayInMill = 86400000;
    const WarningDays = 2;
    let date = new Date(ticket.expirationDate);

    if (date.valueOf() < Date.now().valueOf()) return "expired";
    else if ((date.valueOf() - (dayInMill * WarningDays)) < Date.now().valueOf()) return "almost-expired";

    return "not-close-expired";
  }

  goToTicket(item) {
    this.router.navigate(['ticket', item.id], { relativeTo: this.route.parent, queryParams: { id: item.id } });
  }

  onItemAdded(event) { }

  onItemRemoved(event) { }

  submitTicket() {
    this.newTicket.project = this.project;
    this.newTicket.dateSubmitted = new Date(Date.now());
    let tags = [];
    this.chips.forEach(chip => { tags.push(new Tag(chip)); });
    this.newTicket.tags = tags;

    this._ticketService.newTicket(this.newTicket, this.project.id).subscribe(res => this.onTicketSubmitted(), err => console.log());
  }


  loseFocus(event) {
    var target = event.target || event.srcElement || event.currentTarget;
    target.blur();
  }

  onDeleteTicket(ticket: Ticket) {
    this._ticketService.deleteTicket(ticket).subscribe(res => { this.updateProject(); }, err => console.log(err));
  }

  onEsculateTicket(ticket: Ticket) {
    ticket.esculated = true;
    this.saveTicket(ticket);
  }

  onSuspendTicket(ticket: Ticket) {
    ticket.suspended = !ticket.suspended;
    this.saveTicket(ticket);
  }

  onDateSelected(ngbDate: NgbDate, ticket: Ticket) {
    ticket.expirationDate = new Date(ngbDate.year, ngbDate.month - 1, ngbDate.day);
    this.saveTicket(ticket);
  }

  onPinTicket(ticket: Ticket) {
    this._ticketService.pinTicket(ticket).subscribe();
  }

  onLeaveProject() {
    this._projectService.leaveProject(this.project).subscribe();
  }

  onCompleteTicket(ticket: Ticket) {
    ticket.fixed = true;
    this._ticketService.completeTicket(ticket).subscribe(res => res, err => console.error(err));
  }

  onEditTicket(ticket: Ticket) { }

  parseTextbox(value) {
    let text:string = value.innerText;
    let tagsFilter = text.split(/(?=[!@#$])+/);
    this.buildFilters(tagsFilter);
  }

  setColor(color) {
    document.execCommand('styleWithCSS', false, "true");
    document.execCommand('foreColor', false, color);
  }


  private saveTicket(ticket: Ticket) {
    this._ticketService.saveTicket(ticket).subscribe(res => res, err => console.log(err));
  }

  private onTicketSubmitted() {
    this.updateProject();
    this.newTicket = new Ticket();
    this.chips = [];
  }

  private updateProject() {
    this._projectService.getProjectById(this.projectId).subscribe(
      res => {
        this.project = res;
        this.doFilters();
        this.isOwner = Number(res.ownerId) === Number(localStorage.getItem('userId'));
        this.changeDetector.detectChanges();
      },
      err => console.log(err)
    );
  }

  private doFilters() {
    this.tickets = this.project.tickets;

    if (this.filterSuspended) 
      this.tickets = this.tickets.filter(s => !s.suspended);
    
    if (this.filterClosed) 
      this.tickets = this.tickets.filter(s => !s.fixed);
    
    if (this.filterEsculated) 
      this.tickets = this.tickets.filter(s => !s.esculated);
    

    if (this.filterExpired) {
      this.tickets = this.tickets.filter(s => {
        let date = new Date(s.expirationDate);
        if (s.expirationDate === null) return true;
        return !(date.valueOf() < Date.now().valueOf());
      }
      );
    }

    this.changeDetector.detectChanges();
  }


  private buildFilters(values:Array<string>){
    let tags = []
    let numbers = []
    let titles = []
    let descriptions = []
    this.doFilters();

    values.forEach(s => {
      if(s.charCodeAt(0)==='!'.charCodeAt(0))
        descriptions.push(s.replace('!','').trim());
      
      else if(s.charCodeAt(0)==='@'.charCodeAt(0))
        tags.push(s.replace('@','').trim());
      
      else if(s.charCodeAt(0)==='#'.charCodeAt(0))
        numbers.push(s.replace('#','').trim());
      
      else if(s.charCodeAt(0)==='$'.charCodeAt(0))
        titles.push(s.replace('$','').trim());

      else
        titles.push(s.trim())
    });

    this.doTagFilters(tags);
    this.doTitleFilters(titles);
    this.doDescriptionFilters(descriptions);
    this.doNumberFilters(numbers);
    this.changeDetector.detectChanges();
  }

  private doTagFilters(values:Array<string>) {
    if(values.length ===0 || values === undefined)return;
    values.forEach((value:string )=> {
      this.tickets = this.tickets.filter((ticket: Ticket) => {
        return ticket.tags.some(t => {return t.text.toLowerCase().includes(value.toLowerCase().trim())} )
      });
    }); 
  }

  private doTitleFilters(values:Array<string>) {
    if(values.length ===0 || values === undefined)return;
    values.forEach((value:string )=> {
      this.tickets = this.tickets.filter((ticket: Ticket) => ticket.title.toLowerCase().includes(value.toLowerCase()));
    }); 
  }

  private doDescriptionFilters(values:Array<string>) {
    if(values.length ===0 || values === undefined)return;
    values.forEach((value:string )=> {
      this.tickets = this.tickets.filter((ticket: Ticket) => ticket.description.toLowerCase().includes(value.toLowerCase()));
    }); 
  }

  private doNumberFilters(values:Array<string>) { 
    if(values.length ===0 || values === undefined)return;
    values.forEach((value:string )=> {
      this.tickets = this.tickets.filter((ticket: Ticket) => String(ticket.id).includes(value));
    }); 
  }
  
  test() {
    console.log(this.filterExpired);
  }


}

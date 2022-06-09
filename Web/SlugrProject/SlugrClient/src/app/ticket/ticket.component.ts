import { Component, OnInit, ChangeDetectorRef, Input, HostListener, AfterViewInit } from '@angular/core';
import { CommentService } from '../comment.service';
import { ActivatedRoute, Router, NavigationEnd } from '@angular/router';
import { TicketService } from '../ticket.service';
import { Ticket } from '../models/ticket';
import { Comment } from '../models/Comment';
import { parse } from 'querystring';
import { ParsedVariable } from '@angular/compiler';

declare let EventSource: any;

@Component({
  selector: 'app-ticket',
  templateUrl: './ticket.component.html',
  styleUrls: ['./ticket.component.scss']
})
export class TicketComponent implements OnInit{

  private ticket: Ticket = new Ticket();
  @Input() private ticketID: bigint;
  private sub: any;
  private editMode: boolean;
  container: HTMLElement; 
  constructor(private ticketService: TicketService,private commentService: CommentService,private router: Router, private route: ActivatedRoute,private changeDetector: ChangeDetectorRef) {
    this.route.queryParams.subscribe(data => this.ticketID = data.id) 
  }

  ngOnChanges() {
    this.initialiseTicketView();
  }

  initialiseTicketView(){
    
    this.ticketService.getTicket(this.ticketID).subscribe(
      res => { this.ticket = res; this.updateComments(); },
      err => { console.log(err) }
    )

    if(this.sub != undefined)
      this.sub.unsubscribe();
  }

  ngOnInit() {this.initialiseTicketView();}

  ngOnDestroy() {
    if(this.sub)
      this.sub.unsubscribe();
  }

  submitComment(e) {
    if (e.keyCode == 13 && !e.shiftKey) e.preventDefault();
    if (e.target.value === "") return;

    if (e.keyCode == 13) {
      this.commentService.postComment(e.target.value, this.ticket.id).subscribe(
        res => {
          this.ticketService.getTicket(this.ticketID).subscribe(
            res => { 
              this.updateTicketData(res); 
              e.target.value = "";  

              var container = document.getElementById("comment-body");

              container.scrollTop = container.scrollHeight;
          },
            err => { console.log(err) }
          )

        },
        err => { console.log(err); }
      )  
    }
  }

  updateComments() {
    this.sub = this.ticketService.getUpdate(this.ticket).subscribe(
      res => {
        this.updateTicketData(res);
        this.updateComments();
        this.playCommentSound();
      },
      err => {
          this.updateComments();
      }
    )
  }

  updateTicketData(res) {
    this.ticket = res; 
    
    this.changeDetector.detectChanges();
  }

  onDeleteComment(comment: Comment) {
    this.commentService.deleteComment(comment).subscribe(
      res => {
        let index = this.ticket.comments.indexOf(comment);
        if (index !== -1) this.ticket.comments.splice(index, 1);
        this.changeDetector.detectChanges();
      },
      err => { console.log(err) }
    );
  }

  getProfileLink(comment: Comment) {
    return "/user/" + comment.account.id + "/profile"
  }

  isMyComment(comment: Comment): boolean {
    let id: number = Number(localStorage.getItem('userId'));
    return (id === Number(comment.account.id));
  }

  resizeTextArea(thing) {
    //thing.style.height = "";
    //thing.style.height = thing.scrollHeight + "px";
  }

  playCommentSound(){
    let audio = new Audio();
    audio.src = "../assets/sounds/comment.wav";
    audio.load();
    audio.play();

  }


  editComment(comment:Comment, text){
    if(text === "" || text === undefined || text === "undefined") return  comment.text
    comment.text = text;
    this.commentService.editComment(comment).subscribe(res=>res,err=>console.error(err));
    return text; 
  }

  pasteUrl(e: any){
    const items = (e.clipboardData || e.originalEvent.clipboardData).items;
    let blob = null;
    for (const item of items) {
      if (item.type.indexOf('image') === 0) {
        blob = item.getAsFile();
        console.log(blob); // Prints your files
      }
    } 
  }

}

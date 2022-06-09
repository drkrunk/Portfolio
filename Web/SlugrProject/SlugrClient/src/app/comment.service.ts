import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Comment } from './models/comment';
@Injectable({
  providedIn: 'root'
})
export class CommentService {
  private _url = "http://localhost:9000/api/comments";
  constructor(private http: HttpClient ) { }

  postComment(text:string, ticketId:bigint){
    let comment:Comment = new Comment();
    comment.text = text
    let req = { comment:comment, ticketId: ticketId};

    return this.http.post<any>(this._url+"/post",req);
  }

  deleteComment(comment:Comment){
    return this.http.post<any>(this._url+"/delete",comment)
  }

  editComment(comment:Comment){
    return this.http.post<any>(this._url+"/edit",comment)
  }


}

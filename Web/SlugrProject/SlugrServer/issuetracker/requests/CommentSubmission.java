package com.nathenpadilla.issuetracker.requests;

import com.nathenpadilla.issuetracker.model.Comment;

public class CommentSubmission {
	private Comment comment;
	private Integer ticketId;
	
	public CommentSubmission() {}

	public Comment getComment() {
		return comment;
	}

	public void setComment(Comment comment) {
		this.comment = comment;
	}

	public Integer getTicketId() {
		return ticketId;
	}

	public void setTicketId(Integer ticketId) {
		this.ticketId = ticketId;
	}

	@Override
	public String toString() {
		return "CommentSubmission [comment=" + comment + ", ticketId=" + ticketId + "]";
	}
	
	
	
}

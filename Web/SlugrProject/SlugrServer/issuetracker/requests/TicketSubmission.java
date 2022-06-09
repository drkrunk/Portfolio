package com.nathenpadilla.issuetracker.requests;

import java.util.Set;

import com.nathenpadilla.issuetracker.model.Project;
import com.nathenpadilla.issuetracker.model.Tag;
import com.nathenpadilla.issuetracker.model.Ticket;

public class TicketSubmission {
	private Ticket ticket;
	private Integer project;


	public TicketSubmission(Ticket ticket, Integer project, Set<Tag> tags) {
		this.ticket = ticket;
		this.project = project;
	}

	public Ticket getTicket() {
		return ticket;
	}

	public void setTicket(Ticket ticket) {
		this.ticket = ticket;
	}

	public Integer getProject() {
		return project;
	}

	public void setProject(Integer project) {
		this.project = project;
	}


	
	

}

package com.nathenpadilla.issuetracker.model;

import java.io.Serializable;
import java.sql.Date;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Iterator;
import java.util.List;
import java.util.Set;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.OneToMany;
import javax.persistence.OneToOne;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonIgnore;

@Entity
@Table(name = "Ticket")
public class Ticket implements Serializable {
	private static final long serialVersionUID = -6262693227764818214L;

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Integer id;

	@OneToOne(fetch = FetchType.EAGER)
	@JoinColumn(name = "account_id")
	private Account account;
	

	@ManyToOne(fetch = FetchType.EAGER,cascade = CascadeType.DETACH)
	@JoinColumn(name = "project_id", nullable = false)
	@JsonIgnore
	private Project project;

	@Column(name = "worker_id", nullable = true)
	private Integer workerId;

	
	@Column(name = "title", nullable = false)
	private String title;
	
	@Column(name = "description", nullable = false)
	private String description;

	@Column(name = "date_submitted")
	private Date dateSubmitted;

	@Column(name = "date_fixed", nullable = true)
	private Date dateFixed;

	@Column(name = "expiration_date", nullable = true)
	private Date expirationDate;

	private boolean fixed = false;

	private boolean esculated = false;

	private boolean suspended = false;


	@OneToMany(fetch = FetchType.EAGER, mappedBy = "ticket", cascade = CascadeType.REMOVE, orphanRemoval = true)
	private List<Comment> comments;
	
	@OneToMany(fetch = FetchType.EAGER, mappedBy = "ticket", cascade = CascadeType.REMOVE, orphanRemoval = true)
	private Set<Tag> tags;

	
	public Ticket() {
	}

	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}



	public Account getAccount() {
		return account;
	}

	public void setAccount(Account account) {
		this.account = account;
	}

	public static long getSerialversionuid() {
		return serialVersionUID;
	}

	public Integer getWorkerId() {
		return workerId;
	}

	public void setWorkerId(Integer workerId) {
		this.workerId = workerId;
	}

	public String getTitle() {
		return title;
	}

	public void setTitle(String title) {
		this.title = title;
	}

	public String getDescription() {
		return description;
	}

	public void setDescription(String description) {
		this.description = description;
	}

	public Date getDateSubmitted() {
		return dateSubmitted;
	}

	public void setDateSubmitted(Date dateSubmitted) {
		this.dateSubmitted = dateSubmitted;
	}

	public Date getDateFixed() {
		return dateFixed;
	}

	public void setDateFixed(Date dateFixed) {
		this.dateFixed = dateFixed;
	}

	public boolean isFixed() {
		return fixed;
	}

	public void setFixed(boolean fixed) {
		this.fixed = fixed;
	}

	public List<Comment> getComments() {
		return comments;
	}

	public void setComments(List<Comment> comments) {
		this.comments = comments;
	}


	
	public Project getProject() {
		return project;
	}

	public void setProject(Project project) {
		this.project = project;
	}

	public Date getExpirationDate() {
		return expirationDate;
	}

	public void setExpirationDate(Date expirationDate) {
		this.expirationDate = expirationDate;
	}

	public boolean isEsculated() {
		return esculated;
	}

	public void setEsculated(boolean esculated) {
		this.esculated = esculated;
	}

	public boolean isSuspended() {
		return suspended;
	}

	public void setSuspended(boolean suspended) {
		this.suspended = suspended;
	}
	

	public Set<Tag> getTags() {
		return tags;
	}

	public void setTags(Set<Tag> tags) {
		this.tags = tags;
	}

	public boolean areCommentsEqual(Ticket other) {
		if(other == null) return false; 
	
		List<Comment> otherComments = other.getComments();
		if(otherComments == null) return false;
		
		if(this.comments.size() != otherComments.size())  return false;
		
		int index = 0;
		for(Comment oc: otherComments ) {
			byte[] rv =	this.comments.get(index).getRowVersion();
			
			if(!Arrays.equals(rv, oc.getRowVersion())) return false;
			
			index++;
		}
		
		
		return true;
	}

	@Override
	public String toString() {
		return "Ticket [id=" + id + ", account=" + account + ", project=" + project + ", workerId=" + workerId
				+ ", title=" + title + ", description=" + description + ", dateSubmitted=" + dateSubmitted
				+ ", dateFixed=" + dateFixed + ", expirationDate=" + expirationDate + ", fixed=" + fixed
				+ ", esculated=" + esculated + ", suspended=" + suspended + ", comments=" + comments + "]";
	}
	
	

}

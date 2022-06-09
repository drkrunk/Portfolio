package com.nathenpadilla.issuetracker.model;

import java.io.Serializable;
import java.util.Arrays;
import java.util.Date;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.OneToOne;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonIgnore;

@Entity
@Table(name = "Comment")
public class Comment implements Serializable, Comparable<Comment> {

	public static byte[] latestRowversion;

	private static final long serialVersionUID = -3128081982571379880L;

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Integer id;

	@OneToOne()
	@JoinColumn(name = "account_id")
	private Account account;

	@ManyToOne()
	@JoinColumn(name = "ticket_id", nullable = false)
	@JsonIgnore
	private Ticket ticket;

	@Column(name = "comment")
	private String text;

	@Column(name = "posted_on")
	private Date postedOn = new Date(java.lang.System.currentTimeMillis());

	@Column(name = "rowversion", insertable = false, updatable = false)
	private byte[] rowVersion;

	public Comment() {
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

	public Ticket getTicket() {
		return ticket;
	}

	public void setTicket(Ticket ticket) {
		this.ticket = ticket;
	}

	public String getText() {
		return text;
	}

	public void setText(String text) {
		this.text = text;
	}

	public Date getPostedOn() {
		return postedOn;
	}

	public void setPostedOn(Date postedOn) {
		this.postedOn = postedOn;
	}

	public byte[] getRowVersion() {
		return rowVersion;
	}

	public void setRowVersion(byte[] rowVersion) {
		this.rowVersion = rowVersion;
	}



	@Override
	public int compareTo(Comment o) {
		return getPostedOn().compareTo(o.getPostedOn());
	}

}

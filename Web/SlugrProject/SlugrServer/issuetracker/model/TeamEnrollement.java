package com.nathenpadilla.issuetracker.model;

import java.io.Serializable;

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

import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonSetter;

@Entity
@Table(name = "Enrollment")
public class TeamEnrollement implements Serializable {
	private static final long serialVersionUID = -5797688977367422633L;

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Integer id;

	@OneToOne()
	@JoinColumn(name = "account_id")
	private Account account;

	@ManyToOne(cascade = CascadeType.DETACH)
	@JoinColumn(name = "project_id", nullable = false)
	@JsonIgnore
	private Project project;

	@Column(name = "is_manager")
	private boolean isManager = false;

	public TeamEnrollement() {
	}

	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

	@JsonGetter
	public Account getAccount() {
		return account;
	}

	@JsonSetter
	public void setAccount(Account account) {
		this.account = account;
	}

	public Project getProject() {
		return project;
	}

	public void setProject(Project project) {
		this.project = project;
	}

	public boolean isManager() {
		return isManager;
	}

	public void setManager(boolean isManager) {
		this.isManager = isManager;
	}

	public TeamEnrollement(Integer id, Account account, Project project, boolean isManager) {
		this.id = id;
		this.account = account;
		this.project = project;
		this.isManager = isManager;
	}

	@Override
	public String toString() {
		return "TeamEnrollement [id=" + id + ", account=" + account + ", project=" + project + ", isManager="
				+ isManager + "]";
	}
	
	

}

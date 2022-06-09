package com.nathenpadilla.issuetracker.model;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.OneToMany;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonAnyGetter;
import com.fasterxml.jackson.annotation.JsonGetter;
import com.fasterxml.jackson.annotation.JsonSetter;

@Entity
@Table(name = "Project")
public class Project implements Serializable {
	private static final long serialVersionUID = -6457659399040827227L;

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Integer id;

	@Column(name = "owner_id")
	private Integer ownerId;

	@Column(name = "is_public_project")
	private boolean isPublicProject = false;

	@Column(name = "name")
	private String projectName;

	@Column(name = "decription")
	private String projectDescription;

	@OneToMany(mappedBy = "project", cascade = CascadeType.ALL, orphanRemoval = true)
	private List<Ticket> tickets = new ArrayList<Ticket>();

	@OneToMany(mappedBy = "project", cascade = CascadeType.ALL, orphanRemoval = true)
	private List<TeamEnrollement> team = new ArrayList<TeamEnrollement>();

	public Project() {
	}

	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

	public Integer getOwnerId() {
		return ownerId;
	}

	public void setOwnerId(Integer ownerId) {
		this.ownerId = ownerId;
	}

	public boolean isPublicProject() {
		return isPublicProject;
	}

	public void setPublicProject(boolean isPublicProject) {
		this.isPublicProject = isPublicProject;
	}

	public String getProjectName() {
		return projectName;
	}

	public void setProjectName(String projectName) {
		this.projectName = projectName;
	}

	public String getProjectDescription() {
		return projectDescription;
	}

	public void setProjectDescription(String projectDescription) {
		this.projectDescription = projectDescription;
	}

	@JsonGetter
	public List<Ticket> getTickets() {
		return tickets;
	}

	@JsonSetter
	public void setTickets(List<Ticket> tickets) {
		this.tickets = tickets;
	}

	@JsonGetter
	public List<TeamEnrollement> getTeam() {
		return team;
	}

	@JsonSetter
	public void setTeam(List<TeamEnrollement> team) {
		this.team = team;
	}

	@Override
	public String toString() {
		return "Project [id=" + id + ", ownerId=" + ownerId + ", isPublicProject=" + isPublicProject + ", projectName="
				+ projectName + ", projectDescription=" + projectDescription + ", tickets=" + tickets.size() + ", team=" + team.size()
				+ "]";
	}

}

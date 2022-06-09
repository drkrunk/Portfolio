package com.nathenpadilla.issuetracker.model;

import java.io.Serializable;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.OneToOne;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonProperty;

@Entity
@Table(name = "Account")
public class Account implements Serializable {

	private static final long serialVersionUID = -3788862081195910182L;

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)

	private Integer id;

	@Column(name = "role_id")
	private Integer roleId = 1;

	@Column(name = "user_name", unique = true)
	private String userName;

	@Column(name = "email", unique = true)
	private String email;

	@Column(name = "credentials_expired")
	@JsonIgnore
	private boolean credentialsExpired = false;

	private String password;
	
	@OneToOne(mappedBy = "account", cascade = CascadeType.ALL, orphanRemoval = true)
	private Bio bio;
	
	@Column(name = "is_typing")
	private boolean isTyping = false;
	
	@Column(name = "current_ticket_view_id")
	private Integer currentTicketView = null;

	@JsonIgnore
	private boolean active = true;

	@JsonIgnore
	private boolean locked = false;

	@JsonIgnore
	private boolean enabled = true; 
	
	@OneToMany(fetch = FetchType.EAGER, mappedBy = "account", cascade = CascadeType.REMOVE, orphanRemoval = true)
	private Set<Pin> pinnedTickets;

	public Account() {}


	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

	public Integer getRoleId() {
		return roleId;
	}

	public void setRoleId(Integer roleId) {
		this.roleId = roleId;
	}



	public String getUserName() {
		return userName;
	}

	public void setUserName(String userName) {
		this.userName = userName;
	}



	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	@JsonIgnore
	public String getPassword() {
		return password;
	}

	@JsonProperty
	public void setPassword(String password) {
		this.password = password;
	}

	public boolean isCredentialsExpired() {
		return credentialsExpired;
	}

	public void setCredentialsExpired(boolean credentialsExpired) {
		this.credentialsExpired = credentialsExpired;
	}

	public boolean isActive() {
		return active;
	}

	public void setActive(boolean active) {
		this.active = active;
	}

	public boolean isLocked() {
		return locked;
	}

	public void setLocked(boolean locked) {
		this.locked = locked;
	}

	public boolean isEnabled() {
		return enabled;
	}

	public void setEnabled(boolean enabled) {
		this.enabled = enabled;
	}


	public Bio getBio() {
		return bio;
	}


	public void setBio(Bio bio) {
		this.bio = bio;
	}


	public boolean isTyping() {
		return isTyping;
	}


	public void setTyping(boolean isTyping) {
		this.isTyping = isTyping;
	}


	public Integer getCurrentTicketView() {
		return currentTicketView;
	}


	public void setCurrentTicketView(Integer currentTicketView) {
		this.currentTicketView = currentTicketView;
	}

	
	
	public Set<Pin> getPinnedTickets() {
		return pinnedTickets;
	}


	public void setPinnedTickets(Set<Pin> pinnedTickets) {
		this.pinnedTickets = pinnedTickets;
	}


	@Override
	public String toString() {
		return "Account [id=" + id + ", roleId=" + roleId + ", userName=" + userName + ", email=" + email
				+ ", credentialsExpired=" + credentialsExpired + ", password=" + password + ", bio=" + bio
				+ ", isTypeing=" + isTyping + ", currentTicketView=" + currentTicketView + ", active=" + active
				+ ", locked=" + locked + ", enabled=" + enabled + "]";
	}


	@JsonIgnore
	public Set<String> getRoles() {
		HashSet<String> set = new HashSet<String>();
		set.add("USER");
		return set;
	}

}

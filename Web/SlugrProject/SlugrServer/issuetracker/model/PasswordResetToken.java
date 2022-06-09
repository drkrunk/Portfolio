package com.nathenpadilla.issuetracker.model;

import java.sql.Date;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.OneToOne;
import javax.persistence.Table;


@Entity
@Table(name = "ResetToken")
public class PasswordResetToken {

	private static final int EXPIRATION = 60 * 24;
	 
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer id;
 
    @Column(name = "token")
    private String token;
 
    @OneToOne()
	@JoinColumn(name = "account_id")
    private Account account;
 
    @Column(name = "expiration")
    private Date expirationDate;

	public PasswordResetToken() {}

	public PasswordResetToken(String token, Account account) {
		this.token = token;
		this.account = account;
	}
	
	
    
    
	
}

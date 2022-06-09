package com.nathenpadilla.issuetracker.config;

import java.util.Arrays;

import org.springframework.security.core.authority.SimpleGrantedAuthority;
import org.springframework.security.core.userdetails.User;
import org.springframework.security.core.userdetails.UserDetails;

import com.nathenpadilla.issuetracker.model.Account;

public class UserDetailsImpl extends User implements UserDetails {
	private static final long serialVersionUID = 102086249810739853L;

	private Account account;

	public UserDetailsImpl(Account account) {
		super(account.getUserName(), account.getPassword(), account.isActive(), true, !account.isCredentialsExpired(),
				!account.isLocked(), Arrays.asList(new SimpleGrantedAuthority("USER")));
		this.account = account;

	}

	public Account getAccount() {
		return account;
	}

	public void setAccount(Account account) {
		this.account = account;
	}

}

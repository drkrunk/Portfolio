package com.nathenpadilla.issuetracker.config;

import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.stereotype.Service;

import com.nathenpadilla.issuetracker.model.Account;
import com.nathenpadilla.issuetracker.model.AccountRepository;

@Service("userDetailsService")
public class UserDetailsServiceImpl implements UserDetailsService {

	@Autowired
	AccountRepository accountRespository;

	@Override
	public UserDetails loadUserByUsername(String userName) throws UsernameNotFoundException {
		Optional<Account> account = accountRespository.findByUserName(userName);
		account.orElseThrow(() -> new UsernameNotFoundException("User Not Found: " + userName));
		return account.map(UserDetailsImpl::new).get();
	}

}

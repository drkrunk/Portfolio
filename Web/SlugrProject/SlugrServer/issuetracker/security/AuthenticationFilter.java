package com.nathenpadilla.issuetracker.security;

import java.io.IOException;
import java.util.ArrayList;

import javax.servlet.FilterChain;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.authentication.UsernamePasswordAuthenticationToken;
import org.springframework.security.core.Authentication;
import org.springframework.security.core.AuthenticationException;
import org.springframework.security.core.userdetails.User;
import org.springframework.security.web.authentication.UsernamePasswordAuthenticationFilter;

import com.fasterxml.jackson.databind.ObjectMapper;
import com.nathenpadilla.issuetracker.config.UserDetailsImpl;
import com.nathenpadilla.issuetracker.model.Account;

public class AuthenticationFilter extends UsernamePasswordAuthenticationFilter {
	private AuthenticationManager authenticationManager;

	public AuthenticationFilter(AuthenticationManager authenticationManager) {
		this.authenticationManager = authenticationManager;
	}

	@Override
	public Authentication attemptAuthentication(HttpServletRequest req, HttpServletResponse res) throws AuthenticationException {
		try {
			Account applicationUser = new ObjectMapper().readValue(req.getInputStream(), Account.class);// new Account();//	
			Authentication auth = authenticationManager.authenticate(new UsernamePasswordAuthenticationToken(applicationUser.getUserName(), applicationUser.getPassword(), new ArrayList<>()));
			return auth;
		} catch (Exception e) {throw new RuntimeException(e);}
	}

	@Override
	protected void successfulAuthentication(HttpServletRequest req, HttpServletResponse res, FilterChain chain, Authentication auth) throws IOException, ServletException {
		Account au = ((UserDetailsImpl)auth.getPrincipal()).getAccount();

		String tokenJSON = JWTUtils.GenerateJWT(au);
//createJsonString("Authorization",token);
		res.addHeader("Content-Type", "application/json");
		res.getWriter().write("{");
		res.getWriter().write(tokenJSON);
		res.getWriter().write(",");
		res.getWriter().write(JWTUtils.createJsonString("userID", au.getId())); 
		res.getWriter().write("}");
		res.flushBuffer();
	}
	

}
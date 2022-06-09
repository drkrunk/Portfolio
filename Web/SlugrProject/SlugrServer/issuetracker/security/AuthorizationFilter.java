package com.nathenpadilla.issuetracker.security;

import static com.nathenpadilla.issuetracker.constants.SecurityConstants.HEADER_NAME;

import java.io.IOException;
import java.util.ArrayList;

import javax.servlet.FilterChain;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.authentication.UsernamePasswordAuthenticationToken;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.security.web.authentication.www.BasicAuthenticationFilter;
import org.springframework.util.StringUtils;

import io.jsonwebtoken.Claims;
import io.jsonwebtoken.ExpiredJwtException;

public class AuthorizationFilter extends BasicAuthenticationFilter {

	public AuthorizationFilter(AuthenticationManager authManager) {
		super(authManager);
	}

	@Override
	protected void doFilterInternal(HttpServletRequest request, HttpServletResponse response, FilterChain chain) throws IOException, ServletException {
		String header = request.getHeader(HEADER_NAME);
		if (header == null) { chain.doFilter(request, response); return;}

		try {

			SecurityContextHolder.getContext().setAuthentication(authenticate(request));
		}catch(ExpiredJwtException ex) {
			allowForRefreshToken(ex, request);

		}
		catch(Exception e) {
			//e.printStackTrace();
		}
		
		
		chain.doFilter(request, response);
	}
	
	private UsernamePasswordAuthenticationToken authenticate(HttpServletRequest request) {
		String token = request.getHeader(HEADER_NAME);
		if (token == null) return null;
		token = extractJwtFromRequest(request);

		Claims user = JWTUtils.getClaimsFromToken(token);
		return (user != null) ? new UsernamePasswordAuthenticationToken(user, null, new ArrayList<>()) : null;
	}
	
	
	private void allowForRefreshToken(ExpiredJwtException ex, HttpServletRequest request) {
		UsernamePasswordAuthenticationToken usernamePasswordAuthenticationToken = new UsernamePasswordAuthenticationToken(null, null, null);
		SecurityContextHolder.getContext().setAuthentication(usernamePasswordAuthenticationToken);
		System.out.println("reauthenticate");
		request.setAttribute("claims", ex.getClaims());
	}


	
	private String extractJwtFromRequest(HttpServletRequest request) {
		String bearerToken = request.getHeader("Authorization");
		if (StringUtils.hasText(bearerToken) && bearerToken.startsWith("Bearer "))
			return bearerToken.substring(7, bearerToken.length());
		
		return null;
	}


}
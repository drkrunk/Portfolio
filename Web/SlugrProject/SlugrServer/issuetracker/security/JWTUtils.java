package com.nathenpadilla.issuetracker.security;

import static com.nathenpadilla.issuetracker.constants.SecurityConstants.EXPIRATION_TIME;
import static com.nathenpadilla.issuetracker.constants.SecurityConstants.KEY;

import java.security.Key;
import java.util.Date;
import java.util.HashMap;
import java.util.Map;

import org.springframework.security.authentication.BadCredentialsException;
import org.springframework.security.core.userdetails.User;

import com.nathenpadilla.issuetracker.model.Account;

import io.jsonwebtoken.Claims;
import io.jsonwebtoken.ExpiredJwtException;
import io.jsonwebtoken.Jwts;
import io.jsonwebtoken.MalformedJwtException;
import io.jsonwebtoken.SignatureAlgorithm;
import io.jsonwebtoken.UnsupportedJwtException;
import io.jsonwebtoken.security.Keys;

public class JWTUtils {
	
	public static Claims getClaimsFromToken(String token) {
		return Jwts.parserBuilder().setSigningKey(Keys.hmacShaKeyFor(KEY.getBytes())).build().parseClaimsJws(token).getBody();
	}
	
	public static String RefreshToken(String subject) {
		Date exp = new Date(System.currentTimeMillis() + EXPIRATION_TIME);
		Key key = Keys.hmacShaKeyFor(KEY.getBytes());
		Claims claims = Jwts.claims().setSubject(subject);
		String token = Jwts.builder().setClaims(claims).signWith( key,SignatureAlgorithm.HS512).setExpiration(exp).compact();

		return createJsonString("Authorization",token);
	}
	

	public static String GenerateJWT(Account account) {
		Date exp = new Date(System.currentTimeMillis() + EXPIRATION_TIME);
		Key key = Keys.hmacShaKeyFor(KEY.getBytes());
		Claims claims = Jwts.claims().setSubject(account.getUserName());
		String token = Jwts.builder().setClaims(claims).signWith( key,SignatureAlgorithm.HS512).setExpiration(exp).compact();
		return createJsonString("Authorization",token);	
	}
	
	
	public static String createJsonString(String key, String value) {
		StringBuilder sb = new StringBuilder();
		sb.append("\"");
		sb.append(key);
		sb.append("\"");
		sb.append(":");
		sb.append("\"");
		sb.append(value);
		sb.append("\"");		
				
		return sb.toString();
	}
	
	public static String createJsonString(String key, Integer value) {
		StringBuilder sb = new StringBuilder();
		sb.append("\"");
		sb.append(key);
		sb.append("\"");
		sb.append(":");
		sb.append(value);
				
		return sb.toString();
	}
	
	
	public static boolean validateToken(String authToken) {
		try {
			Jwts.parserBuilder().setSigningKey(Keys.hmacShaKeyFor(KEY.getBytes())).build().parseClaimsJws(authToken).getBody();
			return true;
		} catch (MalformedJwtException | UnsupportedJwtException | IllegalArgumentException ex) {
			throw new BadCredentialsException("INVALID_CREDENTIALS", ex);
		} catch (ExpiredJwtException ex) {
			throw ex;
		}
	}
}

package com.nathenpadilla.issuetracker.controllers;


import java.util.ArrayList;
import java.util.Comparator;
import java.util.UUID;

import javax.servlet.http.HttpServletRequest;
import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.nathenpadilla.issuetracker.model.Account;
import com.nathenpadilla.issuetracker.model.AccountRepository;
import com.nathenpadilla.issuetracker.model.Bio;
import com.nathenpadilla.issuetracker.model.BioRepository;
import com.nathenpadilla.issuetracker.model.PasswordResetToken;
import com.nathenpadilla.issuetracker.model.Pin;
import com.nathenpadilla.issuetracker.model.Ticket;
import com.nathenpadilla.issuetracker.security.JWTUtils;

import io.jsonwebtoken.Claims;

@RestController
@RequestMapping("/api")
public class UserController {

	@Autowired
    private AccountRepository accountRepository;
	
	@Autowired
    private BioRepository bioRepository;
    
	@Autowired
    private BCryptPasswordEncoder bCryptPasswordEncoder;
	

	@PostMapping("/reset-password")
	public ResponseEntity<?> resetPassword(HttpServletRequest request, @RequestBody String userEmail) {
	    Account user = accountRepository.findByEmail(userEmail).get();
	    
	    if (user == null) 
	    	return ResponseEntity.badRequest().body("User not found");
	    
	    String token = UUID.randomUUID().toString();
	    PasswordResetToken myToken = new PasswordResetToken(token, user);
	    
	    

	    return ResponseEntity.ok(token);
	}

    
    //TODO Error handing duplicates
    @PostMapping("/register")
    public ResponseEntity<?> signUp(@Valid @RequestBody Account user) {	
    	if( !accountRepository.findByUserName(user.getUserName()).isEmpty())return ResponseEntity.badRequest().body("Username taken.");
    	if( !accountRepository.findByEmail(user.getEmail()).isEmpty())return ResponseEntity.badRequest().body("Email was already used.");
    	if( user.getUserName() == null)return ResponseEntity.badRequest().body("Username must not be empty.");
    	if( user.getEmail() ==  null)return ResponseEntity.badRequest().body("Email must not be empty.");
    	if( user.getPassword() ==  null)return ResponseEntity.badRequest().body("Password must not be empty.");
    	
        user.setPassword(bCryptPasswordEncoder.encode(user.getPassword())); 
        
        //Save user
        Account account = accountRepository.save(user);
        
        //Create a Account Bio
        Bio bio = new Bio();
        bio.setAccount(user);
    	bioRepository.save(bio);
    	
    	//Generate JWT
    	String tokenJSON = JWTUtils.GenerateJWT(account);
    	return ResponseEntity.ok("{"+tokenJSON+"}");

    }
    
    //Refresh JWT  
    @GetMapping("/refresh")
    public ResponseEntity<?> refreshToken(HttpServletRequest request){
    	Claims claims = (Claims) request.getAttribute("claims");
    	
    	Account account = accountRepository.findByUserName(claims.getSubject()).get();
    	
    	String tokenJSON = JWTUtils.GenerateJWT(account);
    	return ResponseEntity.ok("{"+tokenJSON+"}");
    }
    
    
    @GetMapping("/pins")
    public ResponseEntity<?> getPins(){
    	Claims userDetails = (Claims) SecurityContextHolder.getContext().getAuthentication().getPrincipal();
		Account account = accountRepository.findByUserName(userDetails.getSubject()).get();
    	
    	System.out.println(account.getPinnedTickets().size());
    	
    	ArrayList<Ticket> tickets = new ArrayList<Ticket>();
    	
    	for( Pin p : account.getPinnedTickets()) 
    		tickets.add(p.getTicket());
    	
    	
    	tickets.sort(new Comparator<Ticket>() {

			@Override
			public int compare(Ticket o1, Ticket o2) {

				return o1.getId() - o2.getId();
			}
		});
    	
    	return ResponseEntity.ok(tickets);
    }
    
}





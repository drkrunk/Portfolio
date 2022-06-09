package com.nathenpadilla.issuetracker.controllers;

import java.util.List;
import java.util.concurrent.CompletableFuture;
import java.util.concurrent.TimeUnit;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.context.request.async.DeferredResult;

import com.nathenpadilla.issuetracker.model.Account;
import com.nathenpadilla.issuetracker.model.AccountRepository;
import com.nathenpadilla.issuetracker.model.Comment;
import com.nathenpadilla.issuetracker.model.CommentRepository;
import com.nathenpadilla.issuetracker.model.Project;
import com.nathenpadilla.issuetracker.model.Ticket;
import com.nathenpadilla.issuetracker.model.TicketRepository;
import com.nathenpadilla.issuetracker.requests.CommentSubmission;

import io.jsonwebtoken.Claims;

@RestController
@RequestMapping("/api/comments")
public class CommentController {
	@Autowired
	CommentRepository respository;
	
	@Autowired
	AccountRepository accountRepository;
	
	@Autowired
	CommentRepository commentRepository;
	
	@Autowired
	TicketRepository ticketRepository;
	
	@GetMapping("/all")
	public List<Comment> findAllComments() {
		return respository.findAll();
	}
	
	@GetMapping("/my")
	public List<Comment> allOwnersComments() {
		Claims userDetails = (Claims) SecurityContextHolder.getContext().getAuthentication().getPrincipal();
		Account user = accountRepository.findByUserName(userDetails.getSubject()).get();
		return commentRepository.findByOwner(user.getId());
	}
	
	@PostMapping("/user")
	public List<Comment> allProjectByUser(@RequestBody Account user) {
		return commentRepository.findByOwner(user.getId());
	}
	
	@PostMapping("/ticket")
	public List<Comment> allProjectByTicket(@RequestBody Ticket ticket) {
		return commentRepository.findByOwner(ticket.getId());
	}
	
	@PostMapping("/delete")
	public ResponseEntity<?> deleteComment(@Valid @RequestBody Comment comment) {
		Claims userDetails = (Claims) SecurityContextHolder.getContext().getAuthentication().getPrincipal();
		Account user = accountRepository.findByUserName(userDetails.getSubject()).get();
		Comment delete = commentRepository.getOne(comment.getId());
		
		if(delete.getAccount().getId() == user.getId())
			commentRepository.delete(delete);
		
		return ResponseEntity.ok(delete.getId());
	}
	
	@PostMapping("/post")
	public Comment postProject(@RequestBody CommentSubmission commentSub) {
		Claims userDetails = (Claims) SecurityContextHolder.getContext().getAuthentication().getPrincipal();
		Account user = accountRepository.findByUserName(userDetails.getSubject()).get();

		Ticket ticket  = ticketRepository.getOne(commentSub.getTicketId());
		
		commentSub.getComment().setTicket(ticket);
		commentSub.getComment().setAccount(user);
		
		Comment comment =commentRepository.saveAndFlush(commentSub.getComment());
		
		Comment.latestRowversion = comment.getRowVersion();
		
		return comment;
	}
	
	@PostMapping("/edit")
	public Comment editComment(@RequestBody Comment comment) {
		Claims userDetails = (Claims) SecurityContextHolder.getContext().getAuthentication().getPrincipal();
		Account user = accountRepository.findByUserName(userDetails.getSubject()).get();
		
		if(comment.getAccount().getId() != user.getId()) return comment;
		
		Comment result = commentRepository.getOne(comment.getId());
		result.setText(comment.getText());
		
		return commentRepository.saveAndFlush(result);
	}
	
	

	
}

package com.nathenpadilla.issuetracker.controllers;

import java.sql.Date;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;
import java.util.concurrent.ForkJoinPool;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.context.request.async.DeferredResult;

import com.nathenpadilla.issuetracker.model.Account;
import com.nathenpadilla.issuetracker.model.AccountRepository;
import com.nathenpadilla.issuetracker.model.Pin;
import com.nathenpadilla.issuetracker.model.PinRespository;
import com.nathenpadilla.issuetracker.model.ProjectRepository;
import com.nathenpadilla.issuetracker.model.Tag;
import com.nathenpadilla.issuetracker.model.TagRepository;
import com.nathenpadilla.issuetracker.model.Ticket;
import com.nathenpadilla.issuetracker.model.TicketRepository;
import com.nathenpadilla.issuetracker.requests.TicketSubmission;

import io.jsonwebtoken.Claims;


@RestController
@RequestMapping("/api/ticket")
public class TicketController {

	@Autowired
	TicketRepository ticketRespository;

	@Autowired
	AccountRepository accountRespository;

	@Autowired
	ProjectRepository projectRepository;

	
	@Autowired
	PinRespository pinRepository;
	
	@Autowired
	TagRepository tagRepository;
	
	@PostMapping("/submit")
	public Ticket submitTicket(@Valid @RequestBody TicketSubmission ticketsub) {

		Claims userDetails = (Claims) SecurityContextHolder.getContext().getAuthentication().getPrincipal();
		Account user = accountRespository.findByUserName(userDetails.getSubject()).get();

		ticketsub.getTicket().setAccount(user);
		ticketsub.getTicket().setProject(projectRepository.getOne(ticketsub.getProject()));
		
		Ticket ticket = ticketRespository.save(ticketsub.getTicket());
		
		for(Tag t : ticketsub.getTicket().getTags()) {
			t.setText(t.getText().trim().toLowerCase());
			t.setTicket(ticketsub.getTicket());
			tagRepository.save(t);
		}

		

		return ticket;
	}
	
	@PostMapping("/complete")
	public Ticket completeTicket(@Valid @RequestBody Ticket ticket) {
		ticket = ticketRespository.getOne(ticket.getId());
		ticket.setDateFixed(new Date(System.currentTimeMillis()));
		ticket.setFixed(true);
		ticket.setExpirationDate(null);
		ticket.setSuspended(false);
		ticket.setEsculated(false);
		
		return ticketRespository.save(ticket);
	}
	
	@PostMapping("/save")
	public Ticket updateTicket(@Valid @RequestBody Ticket ticket) {
		Ticket result = ticketRespository.getOne(ticket.getId());
		
		result.setDateFixed(ticket.getDateFixed());
		result.setDescription(ticket.getDescription());
		result.setTitle(ticket.getTitle());
		result.setExpirationDate(ticket.getExpirationDate());
		result.setSuspended(ticket.isSuspended());
		
		System.out.println();
		System.out.println("TICKET SAVED");
		System.out.println(ticket.isSuspended());
		System.out.println();
		
		return ticketRespository.save(result);
	}

	@PostMapping("/delete")
	public ResponseEntity<?> deleteTicket(@RequestBody Ticket ticket) {
		System.out.println("ID:" + ticket.toString());

		ticketRespository.delete(ticket);
		return ResponseEntity.ok(ticket.getId());
	}

	@GetMapping("/{id}")
	public Ticket findTicket(@PathVariable("id") Integer id) {
		Ticket ticket = ticketRespository.findById(id).get();

		Collections.sort(ticket.getComments());
		return ticket;
	}
	
	@PostMapping("/pin")
	public Ticket pinTicket(@RequestBody Ticket pinnedTicket) {
		
		Claims userDetails = (Claims) SecurityContextHolder.getContext().getAuthentication().getPrincipal();
		Account user = accountRespository.findByUserName(userDetails.getSubject()).get();
		
		Ticket ticket = ticketRespository.findById(pinnedTicket.getId()).get();
		
		Pin pin = new Pin();
		pin.setAccount(user);
		pin.setTicket(ticket);
		
		pinRepository.save(pin);

		return ticket;
	}
	
	@PostMapping("/unpin")
	public ResponseEntity<?> unpinTicket(@RequestBody Ticket pinnedTicket) {
		Claims userDetails = (Claims) SecurityContextHolder.getContext().getAuthentication().getPrincipal();
		Account user = accountRespository.findByUserName(userDetails.getSubject()).get();

		List<Pin> pins =  pinRepository.findPinsFromTicketId(user.getId(), pinnedTicket.getId());
		
		for(Pin p : pins)
			pinRepository.delete(p);
		


		return ResponseEntity.ok(pinnedTicket.getId());
	}

	@GetMapping("/all")
	public List<Ticket> findAllTickets() {
		return ticketRespository.findAll();
	}
	
	@GetMapping("/tag/{tag}")
	public List<Ticket> findTicketByTag(@PathVariable("tag") String tag) {
		return ticketRespository.findByTag(tag.trim().toLowerCase());
	}
	
	@GetMapping("/tags/{tags}")
	public List<Ticket> findTicketByTags(@PathVariable("tags") String tags) {
		
		//tags.replaceAll("\\s+", "");
		String[] stags = tags.split(",");
		
		stags = Arrays.stream(stags).distinct().toArray(String[]::new);
		
		ArrayList<Ticket> list = new ArrayList<Ticket>();
		for(String s : stags) {
			List<Ticket> t = findTicketByTag(s.trim().toLowerCase());
			list.addAll(t);
		}
		
		return list;
	}
	
	
	@PostMapping("/update/")
	public DeferredResult<ResponseEntity<?>> update(@RequestBody Ticket update) {
		DeferredResult<ResponseEntity<?>> output = new DeferredResult<>(1000l);
		
		Ticket ticket = ticketRespository.findById(update.getId()).get();
		
		
		output.onTimeout(() -> 
		output.setErrorResult(
		    ResponseEntity.status(HttpStatus.OK).body("Request timeout occurred."))
		);
		

		ForkJoinPool.commonPool().submit(() -> 
		{
			if(!ticket.areCommentsEqual(update)) {
				output.setResult(ResponseEntity.ok(ticket));
			}
				
			
		});
		return output;
	}

}

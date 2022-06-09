package com.nathenpadilla.issuetracker.model;

import java.util.List;
import java.util.Optional;

import org.springframework.data.domain.Sort;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

public interface TicketRepository extends JpaRepository<Ticket, Integer>{

	<S extends Ticket> S save(S entity);
	Optional<Ticket> findById(Integer id);
	long count();
	List<Ticket> findAll();
	List<Ticket> findAll(Sort sort);
	List<Ticket> findAllById(Iterable<Integer> ids);
	List<Ticket> findByAccountId(Integer accountId);
	List<Ticket> findByTitle(String title);
	List<Ticket> findByWorkerId(Integer workerId);
	
	@Query(value = "SELECT * FROM Ticket INNER JOIN Tag ON Ticket.id = Tag.ticket_id WHERE Tag.text = ?", nativeQuery = true)
	List<Ticket> findByTag( String tagText);
	
	
}

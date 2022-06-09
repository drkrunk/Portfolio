package com.nathenpadilla.issuetracker.model;

import java.util.List;
import java.util.Optional;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

@Repository
public interface CommentRepository extends JpaRepository<Comment, Integer> {

	<S extends Comment> S save(S comment);
	void delete(Comment entity);
	
	Optional<Comment> findById(Integer id);
	void deleteById(Integer id);
	List<Comment> findAll();
	
	@Query(value = "SELECT * FROM Project WHERE account_id = ?", nativeQuery = true)
	List<Comment> findByOwner(Integer account_id);
	
	@Query(value = "SELECT * FROM Project WHERE ticket_id = ?", nativeQuery = true)
	List<Comment> findByTicket(Integer ticket_id);
	
}

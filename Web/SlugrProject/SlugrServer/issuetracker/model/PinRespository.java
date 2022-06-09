package com.nathenpadilla.issuetracker.model;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

public interface PinRespository extends JpaRepository<Pin, Integer>{

	@Query(value = "SELECT * FROM Pin WHERE account_id = ? And ticket_id = ?", nativeQuery = true)
	List<Pin> findPinsFromTicketId(Integer id, Integer ticket_id);
}

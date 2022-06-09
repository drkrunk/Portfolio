package com.nathenpadilla.issuetracker.model;

import java.util.List;
import java.util.Optional;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

public interface TeamEnrollementRepository extends JpaRepository<TeamEnrollement, Integer>{


	@Query(value = "SELECT * FROM Account WHERE is id = ?", nativeQuery = true)
	List<Account> findAccounts(Integer id);
	
	@Query(value = "SELECT * FROM Enrollment WHERE account_id = ? And project_id = ?", nativeQuery = true)
	List<TeamEnrollement> findEnrollmentFromProjectID(Integer id, Integer project_id);
	
}

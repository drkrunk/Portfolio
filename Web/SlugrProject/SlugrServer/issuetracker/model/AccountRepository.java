package com.nathenpadilla.issuetracker.model;
import java.util.List;
import java.util.Optional;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.JpaSpecificationExecutor;
import org.springframework.stereotype.Repository;

@Repository
public interface AccountRepository extends JpaRepository<Account, Integer>, JpaSpecificationExecutor<Account>  {
	
	Optional<Account> findByUserName(String userName);
	Optional<Account> findByEmail(String email);
	Optional<Account> findById(Integer id);
	List<Account> findAll();
	<S extends Account> S save(S entity);
	
	
}

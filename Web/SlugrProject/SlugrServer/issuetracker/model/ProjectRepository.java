package com.nathenpadilla.issuetracker.model;

import java.util.List;
import java.util.Optional;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

public interface ProjectRepository extends JpaRepository<Project, Integer> {

	<S extends Project> S save(S entity);
	Optional<Project> findById(Integer id);
	boolean existsById(Integer id);
	void deleteById(Integer id);
	void delete(Project entity);
	List<Project> findByOwnerId(Integer ownerId);
	
	@Query(value = "SELECT * FROM Project WHERE owner_id = ?", nativeQuery = true)
	List<Project> findByOwner(Integer owner_id);
	
	@Query(value = "SELECT * FROM Project WHERE is_public_project = ?", nativeQuery = true)
	List<Project> findByPublic(boolean isPublic);
	
	@Query(value = "SELECT * FROM Project JOIN Enrollment ON Enrollment.project_id=Project.id WHERE Enrollment.account_id=? and Enrollment.is_manager=0", nativeQuery = true)
	List<Project> findTeamMembers(Integer accountId);
}

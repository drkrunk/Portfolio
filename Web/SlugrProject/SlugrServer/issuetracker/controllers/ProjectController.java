package com.nathenpadilla.issuetracker.controllers;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.security.core.Authentication;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.nathenpadilla.issuetracker.model.Account;
import com.nathenpadilla.issuetracker.model.AccountRepository;
import com.nathenpadilla.issuetracker.model.Project;
import com.nathenpadilla.issuetracker.model.ProjectRepository;
import com.nathenpadilla.issuetracker.model.TeamEnrollement;
import com.nathenpadilla.issuetracker.model.TeamEnrollementRepository;

import io.jsonwebtoken.Claims;

@RestController
@RequestMapping("/api/projects")
public class ProjectController {
	@Autowired
	ProjectRepository projectRepository;

	@Autowired
	AccountRepository accountRepository;

	@Autowired
	TeamEnrollementRepository teamRepository;
	
	

	@GetMapping("/{id}")
	public Optional<Project> getProject(@PathVariable Integer id) {
		return projectRepository.findById(id);
	}

	@GetMapping("/all")
	public List<Project> allProjects() {
		return projectRepository.findAll();
	}

	@GetMapping("/public/all")
	public List<Project> allPublicProjects() {
		return projectRepository.findByPublic(true);
	}

	@GetMapping("/my")
	public List<Project> allOwnersProject() {

		Claims userDetails = (Claims) SecurityContextHolder.getContext().getAuthentication().getPrincipal();
		Account user = accountRepository.findByUserName(userDetails.getSubject()).get();

		return projectRepository.findByOwner(user.getId());
	}

	@PostMapping("/save")
	public Project postProject(@RequestBody Project project) {
		Project p = projectRepository.getOne(project.getId());
		
		p.setProjectDescription(project.getProjectDescription());
		p.setProjectName(project.getProjectName());
		p.setPublicProject(project.isPublicProject());
		

		return projectRepository.saveAndFlush(p);
	}

	@PostMapping("/delete")
	public ResponseEntity<?> deleteProject(@RequestBody Project project) {
		projectRepository.delete(project);
		return ResponseEntity.ok(project.getId());
	}

	@PostMapping("/create")
	public ResponseEntity<?> createProject(Authentication auth, @RequestBody Project project) {

		Claims userDetails = (Claims) SecurityContextHolder.getContext().getAuthentication().getPrincipal();
		Account user = accountRepository.findByUserName(userDetails.getSubject()).get();
		project.setOwnerId(user.getId());

		
		projectRepository.save(project);
			

		return ResponseEntity.ok(project);
	}

	@PostMapping("/members/join")
	public ResponseEntity<?> addMemeber(Authentication auth, @RequestBody Project project){
		Claims userDetails = (Claims) SecurityContextHolder.getContext().getAuthentication().getPrincipal();
		Account user = accountRepository.findByUserName(userDetails.getSubject()).get();
		
		if(user.getId() == project.getOwnerId()) 
			return ResponseEntity.status(412).body("You can't join your own project.");
		
		if(!teamRepository.findEnrollmentFromProjectID(user.getId(), project.getId()).isEmpty())
			return ResponseEntity.status(412).body("You already joined this project.");
		
		TeamEnrollement team = new TeamEnrollement();

		team.setAccount(user);
		team.setProject(projectRepository.getOne(project.getId()));

		TeamEnrollement test = teamRepository.save(team);
		System.out.println("HAS PROJECTS: "+test.toString());
		
		return ResponseEntity.ok(project.getId());
	}
	
	@GetMapping("/team-projects")
	public List<Project> addTeamProjects(Authentication auth){
		Claims userDetails = (Claims) SecurityContextHolder.getContext().getAuthentication().getPrincipal();
		Account user = accountRepository.findByUserName(userDetails.getSubject()).get();
		
		List<Project> projects = projectRepository.findTeamMembers(user.getId());
		
		System.out.println("HAS PROJECTS: "+ !projects.isEmpty());
		
		return projects;
	}
	
	@PostMapping("/leave-project")
	public ResponseEntity<?> leaveProject(Authentication auth, @RequestBody Project project){
		Claims userDetails = (Claims) SecurityContextHolder.getContext().getAuthentication().getPrincipal();
		Account user = accountRepository.findByUserName(userDetails.getSubject()).get();

		List<TeamEnrollement> enrollments = teamRepository.findEnrollmentFromProjectID(user.getId(), project.getId());
		
		for(TeamEnrollement e : enrollments) {
			teamRepository.delete(e);
		}
		return ResponseEntity.ok(project.getId());
	}
}

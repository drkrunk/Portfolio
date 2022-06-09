package com.nathenpadilla.issuetracker.controllers;

import javax.validation.Valid;

import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/api/uploads")
public class UploadController {
	
	@PostMapping("/register")
    public ResponseEntity<?> uploadAvatar(@Valid @RequestBody String image){
		
		return ResponseEntity.ok("{ok:1}");
	}

}

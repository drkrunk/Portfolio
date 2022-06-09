package com.nathenpadilla.issuetracker.slugr;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.autoconfigure.domain.EntityScan;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.data.jpa.repository.config.EnableJpaRepositories;

@SpringBootApplication
@EntityScan(basePackages = {"com.nathenpadilla.issuetracker.model"})
@EnableJpaRepositories(basePackages = {"com.nathenpadilla.issuetracker.model"})
@ComponentScan(basePackages = {"com.nathenpadilla.issuetracker.config"})
@ComponentScan(basePackages = {"com.nathenpadilla.issuetracker.controllers"})
@ComponentScan(basePackages = {"com.nathenpadilla.issuetracker.security"})
@ComponentScan(basePackages = {"com.nathenpadilla.issuetracker.services"})

public class SlugrApplication {

	public static void main(String[] args) {
		SpringApplication.run(SlugrApplication.class, args);
	}
	


}

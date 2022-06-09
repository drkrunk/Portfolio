package com.nathenpadilla.issuetracker.config;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.mail.SimpleMailMessage;
import org.springframework.mail.javamail.JavaMailSenderImpl;

@Configuration
public class EmailConfiguration {

	@Bean
    public SimpleMailMessage emailTemplate(){
        SimpleMailMessage message = new SimpleMailMessage();
        message.setTo("natep182@live.com");
        message.setFrom("natep182@live.com");
        message.setSubject("Test Email");
        message.setText("YAY! It worked.");
        
        return message;
    }


}

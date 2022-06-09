package com.examples.java.nate;

/*
 
Objective: Modify your dice game from last time so that it keeps rolling until they get doubles (the same number on both dice).
Notice that since there's no user input, this will happen very quickly (all the rolls will happen one right after the other).

http://programmingbydoing.com/a/dice-doubles.html

Too easy =[
*/


public class Main {

	public static void main(String[] args) {
	
		int d1 = 0;
		int d2 = -1;
		
		
		System.out.println("HERE COMES THE DICE! \n");
		while (d1 != d2 ) {
			d1 = (int)(Math.random() * 5 + 1);
			d2 = (int)(Math.random() * 5 + 1);
			
			System.out.println("Roll #1: " + d1);
			System.out.println("Roll #2: " + d2);
			System.out.println("The total is " + (d1+d2) + "!");
			System.out.println("\n");
		} 

	}
	

}

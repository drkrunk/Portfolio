package com.examples.java.nate;
import java.util.Scanner;

//Manages the input and output of the story.
public class AdventureManager {

	
	//Game loop
	public static void doAdventure(Room startingRoom) {
		Scanner s = new Scanner(System.in);
		String direction ="";
		Room currentRoom = startingRoom; 
		
		
		while(true) {
			
			System.out.println("You chose " + currentRoom.getName().toLowerCase() +".");
			System.out.println(currentRoom.getStory());
			
			if(currentRoom.hasConnectingRooms()) {
				
				while(!currentRoom.hasRoom(direction)) {
					System.out.println("Please enter a choice.");
					direction = s.next();
					System.out.println("");
				}
				
				if(currentRoom.hasRoom(direction)) currentRoom = currentRoom.getRoomByName(direction);
			}
			else {break;}

		}
		
		s.close();
	}
}

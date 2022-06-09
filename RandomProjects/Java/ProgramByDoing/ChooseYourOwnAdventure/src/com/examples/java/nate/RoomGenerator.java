package com.examples.java.nate;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;


//Loads tree from files.
public class RoomGenerator {

	//Recursively loads rooms from files.
	//Files look like so story|choice1|choice2. The choices corresponds with the filenames of the connecting room.
	public static Room loadRooms(String filename){
		Room currentRoom = null;
		
		try {

			//final File file = new File("src/com/examples/java/nate/rooms/" + filename);
			final File file = new File("rooms/" + filename);
			String[] parts = readFile(file).split("\\|");
			currentRoom = new Room(filename, parts[0]);
			
			for (int i = 1; i < parts.length; i++) 
				currentRoom.addConnectingRoom(loadRooms(parts[i].trim()));
		
		} catch (Exception e) {System.out.println("Can't read or find file: " + filename);}
		
		return currentRoom;
	}
	
	

	private static String readFile(final File file) throws Exception {
		String result = "";
		
		BufferedReader br = new BufferedReader(new FileReader(file));
		
		String tempString ;
		while( (tempString = br.readLine()) !=null) result += tempString +"\n";	
			
		br.close();
		return result;
		
	}
	
}

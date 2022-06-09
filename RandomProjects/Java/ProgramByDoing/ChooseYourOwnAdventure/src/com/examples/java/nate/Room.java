package com.examples.java.nate;

import java.util.ArrayList;


//Each room is a part in the story. Rooms connect to other rooms that the user can chose from. 
public class Room {

	private String name = "";
	private String story = "";
	private ArrayList<Room> connectingRooms = new ArrayList<Room>();

	public Room(String name, String text) {
		this.name = name;
		this.story = text;
	}
	
	public void addConnectingRoom(Room roomToAdd) {
		if(roomToAdd == null)return; //Don't add null rooms to connecting rooms.
		connectingRooms.add(roomToAdd);
	}
	
	public boolean hasConnectingRooms() {
		return !connectingRooms.isEmpty();
	}
	
	public boolean hasRoom(String name) {
		return getRoomByName(name) != null;
	}
	
	public String getName() {
		return name;
	}

	public String getStory() {
		return story;
	}	
	
	public Room getRoomByName(String name) {
		for (Room room : connectingRooms) if(room.getName().equalsIgnoreCase(name)) return room;
		return null;
	}
	
}

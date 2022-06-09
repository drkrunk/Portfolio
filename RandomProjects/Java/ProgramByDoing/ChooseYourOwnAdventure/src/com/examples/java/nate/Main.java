package com.examples.java.nate;


/*The objective: 
 
Make a short "Choose Your Own Adventure" game. The starting room should give the user two choices. Then the second room they travel to should give them two more choices. Finally the third room should give them two choices.
This means your game will have eight possible "endings". Your game will also have a total of fifteen rooms:

        _ R1 _
       /      \
    R2          R3
   /  \        /  \
 R4    R5    R6    R7
 /\    /\    /\    /\
E1 E2 E3 E4 E5 E6 E7 E8
You must use nested if statements to do this.

http://programmingbydoing.com/a/choose-your-own-short-adventure.html


I changed the design to not used nested if statements because I wanted the program to be extendible. Adding another layer to the tree would be nightmare with if statements. I also made it where each room can have any amount choices making the story less ridged.
I can't come up with that much story, so I only did a few routes. 
*/


public class Main {

	public static void main(String[] args) {
		AdventureManager.doAdventure(RoomGenerator.loadRooms("Kitchen"));
		
	}

}

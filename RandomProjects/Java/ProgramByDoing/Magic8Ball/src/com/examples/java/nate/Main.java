package com.examples.java.nate;

/*


Below is the file http://programmingbydoing.com/ provided

import java.util.Random;

public class Magic8Ball
{
	public static void main ( String[] args )
	{
		Random r = new Random();

		int choice = 1 + r.nextInt(15);
		String response = "";

		if ( choice == 1 )
			response = "It is certain";
		else if ( choice == 2 )
			response = "It is decidedly so";
		else if ( choice == 3 )
			response = "Without a doubt";
		else if ( choice == 4 )
			response = "Yes - definitely";
		else if ( choice == 5 )
			response = "You may rely on it";
		else if ( choice == 6 )
			response = "As I see it, yes";
		else if ( choice == 7 )
			response = "Most likely";
		else if ( choice == 8 )
			response = "Outlook good";
		else if ( choice == 9 )
			response = "Signs point to yes";
		else if ( choice == 10 )
			response = "Yes";
		else if ( choice == 11 )
			response = "Reply hazy, try again";
		else if ( choice == 12 )
			response = "Ask again later";
		else if ( choice == 13 )
			response = "Better not tell you now";
		else if ( choice == 14 )
			response = "Cannot predict now";
		else if ( choice == 15 )
			response = "Concentrate and ask again";
		else 
			response = "8-BALL ERROR!";

		System.out.println( "MAGIC 8-BALL SAYS: " + response );
	}
}
Assignments turned in without these things will receive no credit.

The real Magic 8-Ball� contains 20 responses, not 15. Change the code so that it picks a random number from 1-20, and add the following five responses:
Don't count on it
My reply is no
My sources say no
Outlook not so good
Very doubtful


http://programmingbydoing.com/a/magic-8ball.html

There are so many better ways of doing this, so I wrote one. My is extendible without adding more if else statements.
*/

public class Main {

	public static void main(String[] args) {
		new Magic8Ball().printReponse();
	}

}

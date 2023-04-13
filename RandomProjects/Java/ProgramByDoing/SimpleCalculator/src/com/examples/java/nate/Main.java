package com.examples.java.nate;

public class Main {

	public static void main(String[] args) {
		Calculator c = new Calculator(10);
		c.add(3);
		c.subtract(4);
		c.divide(3);
		c.multiply(2);

		System.out.println(c.getResult());
	}

}

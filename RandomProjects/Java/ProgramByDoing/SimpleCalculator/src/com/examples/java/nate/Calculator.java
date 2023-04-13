package com.examples.java.nate;

public class Calculator {
	
	private double result;
	
	
	public Calculator() { result = 0;}
	
	public Calculator(double num1) { result = num1;}
	
	public void add(double num1){ result = result + num1;}

	public void subtract(double num1){result = result - num1;}
	
	public void multiply(double num1) {result = result * num1;}
	
	public void divide(double num1){ result = (num1>0)? result / num1: 0;}
	
	public void clearResult() {result = 0;}
	
	public double getResult() {return result;}
	

	
}

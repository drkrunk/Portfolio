using System;

/*
Author: Nathen Padilla
Project's Objectives: Demonstrate relationship and uses of classes and objects.
This program is written as if the reader has a low understanding of computer programming.
In this project I will attempt to communicate the principles as comments in the appropriate files and sections.
*/

//Namespace of the program used for organization
namespace ClassesAndObjects
{
    //Container class of the prgram
    class Program
    {
        //Entry point to the program
        static void Main(string[] args)
        {

            //This is an example of 2 ExampleObjects being created 
            ExampleClass exampleObject = new ExampleClass();
            ExampleClass exampleObject2 = new ExampleClass();

            //This is an example of an object's public method PrintState() being called 
            exampleObject.PrintState();

            //This is an example of an object state being changed
            exampleObject.SetExampleField("ExampleObject's state changed!");
            exampleObject.PrintState();

            //This is an example of an object state being changed by a global function
            ExampleClass.ExampleGlobalFunction(exampleObject);
            exampleObject.PrintState();

            //Example of accessing the global varible of ExampleClass.
            Console.WriteLine("Number of ExampleClass instances: " + ExampleClass.InstanceCount);

        }
    }
}
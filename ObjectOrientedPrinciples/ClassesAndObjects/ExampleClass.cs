//Class dependencies
using System;
using System.Collections.Generic;
using System.Text;

/*
This is an example of a class in C#.
Classes are the foundational concept behind object oriented programming (OOP) as they are the basic 
blueprints in the object creation. Classes contain the state of the object and its behaviors by the 
means of fields and methods respectively. The class below shows the fundamentals of a class in OOP.
*/

namespace ClassesAndObjects
{
    //Defination of the ExampleClass
    class ExampleClass
    {
        /*
        This is an example of a field of the type String.
        Using the private keyword encapsulates the state of the object by not allowing the field to 
        be accessed outside of this class. Encapsulation is the fundamental concept of a class because 
        it allows the programmer full control the access of the object's state. By changing the keyword 
        to the public or protected would allow access to the field outside of this class. Thus leaving it
        unprotected.

        For the sake of example I used fields instead of properties.
        */
        private String exampleField;

        /*
        Example of a global variable of the Integer type for the ExampleClass.
        By using the static keyword this puts this variable in the global space of the class. Globals act 
        outside the object. Global variables are not protected and can accessed or changed anywhere.
        */
        public static int InstanceCount = 0;

        /*
        This is an example of a constructor.
        A constructor gets called first when the object is created. Its job in the class is to initialize
        the state of the class.
        */
        public ExampleClass() {
            this.exampleField = "ExampleObject created!";
            ExampleClass.InstanceCount++;
        }

        /*
        This is an example of a public method.
        Methods are the behaviors of the object. In the method below I intentionally call a private method 
        to demonstrate another core principal called abstraction. Abstraction is a tool used by the programmer 
        to limit the object details. Without abstraction there wouldn't be a good way to organize the code 
        and would not allow for the object to hide methods that aren't useful to the object.
        */
        public void PrintState() {
            DoWrite();
        }

        /*
        This is an example of a private method.
        This method can't be accessed outside of this class.
        */
        private void DoWrite() {
            Console.WriteLine(this.exampleField);
        }

        /*
        This is an example of a setter method.
        Setter methods give access to change the fields of the object. By programming a class this way it allows 
        the programmer to control the input of the object's state any number of different ways. For instance, 
        I wanted the input to be formatted a certain way before changing its state.
        */
        public void SetExampleField(String exampleString) {
            this.exampleField = exampleString.ToUpper();
        }

        /*
        This is an example of a getter method.
        Getter methods are a way to access the objects fields that are encapsulated.
        */
        public String GetExampleField(){
            return this.exampleField;
        }

        /*
        Example of global function for ExampleClass.
        Static functions work like a static variables as they work outside of object space. 
        */
        public static void ExampleGlobalFunction(ExampleClass exampleObject) {
            exampleObject.SetExampleField("ExampleObject's state changed by ExampleClass's global function!");
        }

    }
}

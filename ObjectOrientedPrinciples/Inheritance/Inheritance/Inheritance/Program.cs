using System;

/*
Author: Nathen Padilla
Project's Objectives: Demonstrate relationship and uses of parent and child classes.
This program is written as if the reader has a basic understanding of classes.
In this project I will attempt to communicate the principles as comments in the appropriate files and sections.
*/


namespace Inheritance
{
    class Program
    {
        /*
         Inheritance groups like functionality in child/parent relationship
        */
        static void Main(string[] args)
        {

            ParentClass parentClass = new ParentClass();
            parentClass.ParentMethod();
            parentClass.PrintParentProperty();
            parentClass.OverrideParentMethod();
            parentClass.AbstractClassMethod();
            Console.WriteLine("-----------------------------------\n");

            ChildClass childClass = new ChildClass();
            childClass.ParentMethod();
            childClass.ChildMethod();
            childClass.PrintChildProperty();
            childClass.PrintParentProperty();
            childClass.OverrideParentMethod();
            childClass.AbstractClassMethod();
            Console.WriteLine("-----------------------------------\n");


            AbstractClass childClass2 = new ChildClass();
            childClass2.AbstractClassMethod();

        }
    }
}

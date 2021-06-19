using System;

namespace Composite
{
    class Program
    {

        //Composite pattern describes a group of objects that are treated the 
        //same way as a single instance of the same type of object
        static void Main(string[] args)
        {
            //Create composite objects
            Composite composite = new Composite();
            Composite composite2 = new Composite();

            //Create leafs to composite 
            Leaf leaf1 = new Leaf("Leaf 1 did a thing.");
            Leaf leaf2 = new Leaf("Leaf 2 did a thing too.");
            Leaf leaf3 = new Leaf("Leaf 3 wanted to a thing too, but didn't.");

            //Create leafs to composite with another composite
            Leaf leaf4 = new Leaf("Leaf 4 did a thing in a group!");
            Leaf leaf5 = new Leaf("Leaf 5 did a group thing too.");
            Leaf leaf6 = new Leaf("Leaf 6 did a group thing also.");

            //Add to composite1
            composite.Add(leaf1);
            composite.Add(leaf2);
            composite.Add(leaf3);

            //Add to composite2
            composite2.Add(leaf4);
            composite2.Add(leaf5);
            composite2.Add(leaf6);

            //Composites can be add to each other like a group
            composite.Add(composite2);

            //Does all actions in all groups
            composite.Action();

        }
    }
}

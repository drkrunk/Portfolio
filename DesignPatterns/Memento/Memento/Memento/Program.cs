using System;
using System.Collections.Generic;

namespace Memento
{
    class Program
    {

        //Caretaker
        static void Main(string[] args)
        {
            List<Memento> savedStates = new List<Memento>();

            Originator originator = new Originator();
            originator.SetState("State1");

            savedStates.Add(originator.Create());
            originator.SetState("State2");
            originator.SetState("State3");

            savedStates.Add(originator.Create());
            originator.SetState("State4");

            foreach(var state in savedStates ) 
                originator.Restore(state);

        }
    }
}

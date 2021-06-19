using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {

            bool done = false;

            Context c = new Context();

            while (!done) {
                Console.WriteLine("MENU");
                Console.WriteLine("Please Enter The Number Of The State To Change To:");
                Console.WriteLine("1.)Defined State");
                Console.WriteLine("2.)Another State");
                Console.WriteLine("3.)A Diffrent State");
                Console.WriteLine("Type /exit to exit program");
                Console.WriteLine("-------------------------------------------------\n");
                string userInput = Console.ReadLine();

                if (userInput == "1") { c.ChangeToDefinedState(); }
                if (userInput == "2") { c.ChangeToAnotherState(); }
                if (userInput == "3") { c.ChangeToADiffrentState(); }

                Console.WriteLine("Context's Current State: " + c.GetStateAsString());
                Console.WriteLine("-------------------------------------------------\n\n");

                if (userInput == "/exit") { done = !done;}
            }
        }
    }
}

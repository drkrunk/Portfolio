using System;
using System.Collections.Generic;
using System.Text;

namespace MVC
{
    class View
    {
        public void DisplayInfo(string s) {
            Console.WriteLine("Current Message: "+s);
        }

        public string GetUserInput() {
            return Console.ReadLine();
        }

        public void DisplayIntro()
        {
            Console.WriteLine("Welcome To The Project!");
            Console.WriteLine("Please enter some data so the model can work on it.");
        }

    }
}

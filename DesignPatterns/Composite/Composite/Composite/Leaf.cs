using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    //Data container class
    class Leaf : IComponents
    {
        public string Data { get; set; }

        public Leaf(){}

        public Leaf(string d) { Data = d; }

        //Leaf action.
        public void Action()
        {
            Console.WriteLine(Data);
        }
    }
}

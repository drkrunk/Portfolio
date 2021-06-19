using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class Request
    {
        //Container for the data.
        public string TheData { get; set; }
        public string TheAction { get; set; }

        public Request(string d, string a)
        {
            TheAction = a;
            TheData = d;
        }
    }
}

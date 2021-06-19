using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class Chain
    {
        //1st link in the chain.
        private IProcessor link1;

        public Chain() {
            buildchain(); 
        }

        //Stats the process on the first link of chain.
        public void ProcessRequest(Request request)
        {
            link1.ProcessRequest(request);
        }


        //Builds a chain of processors
        private void buildchain()
        {

            //Create links.
            link1 = new DoUpperProcessor();
            IProcessor link2 = new DoLengthProcessor();
            IProcessor link3 = new DoLowerProcessor();

            //Build Chain by setting it's next link.
            link1.SetNext(link2);
            link2.SetNext(link3);
        }
    }
}

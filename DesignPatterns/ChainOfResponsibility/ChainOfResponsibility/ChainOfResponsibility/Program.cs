using System;

namespace ChainOfResponsibility
{
    class Program
    {
        //Chain of responsibility pattern runs through each link to see if it should process the data.
        static void Main(string[] args)
        {
            //The data of the request.
            Request request = new Request("The Super Important Data!","upper");

            //Builds a chain of processors.
            Chain chain = new Chain();

            //Does request on data.
            chain.ProcessRequest(request);

  
        }
    }
}

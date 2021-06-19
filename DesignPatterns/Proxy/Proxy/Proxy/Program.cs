using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();

            Console.WriteLine(proxy.GetRelevantData());
        }
    }
}

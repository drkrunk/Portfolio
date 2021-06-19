using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton testObject1 = Singleton.Instance;
            testObject1.TestText = "TestObject1";  

            Singleton testObject2 = Singleton.Instance;

            Console.WriteLine(testObject2.TestText);

        }
    }
}

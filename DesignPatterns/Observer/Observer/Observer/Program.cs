using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject cs = new ConcreteSubject();
            ConcreteObserver co = new ConcreteObserver();
            AnotherConcreteObserver ao = new AnotherConcreteObserver();

            cs.Register(co);
            cs.Register(ao);

            cs.SendAnUpdate("Wow what an amazing update!");

        }
    }
}

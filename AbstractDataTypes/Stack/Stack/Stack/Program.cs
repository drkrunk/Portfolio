using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] test = { 10, 12, 15 };
            //Stack<int> stack = new Stack<int>(test);

            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(12);
            stack.Push(15);

            Console.WriteLine("Contains 12: "+stack.Contains(12));
            Console.WriteLine("Contains 0: "+stack.Contains(0));
            Console.WriteLine("Stack Peek: "+stack.Peek());
            Console.WriteLine("Stack Empty: " + stack.Empty);
            Console.WriteLine("Stack Pop: " + stack.Pop());
            Console.WriteLine("Stack Pop: " + stack.Pop());
            Console.WriteLine("Stack Pop: " + stack.Pop());
            Console.WriteLine("Stack Empty: " + stack.Empty);
        }
    }
}

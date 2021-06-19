using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            tree.Insert(13);
            tree.Insert(12);
            tree.Insert(4);
            tree.Insert(10);
            tree.Insert(19);
            tree.Insert(16);
            tree.Insert(9);
            
            Console.WriteLine(tree.Contains(2));
            Console.WriteLine(tree.Contains(16));

            tree.Print();
            tree.Delete(10);
            tree.Print();

        }
    }
}

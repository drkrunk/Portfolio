using System;
using System.Collections.Generic;
using System.Text;

namespace BTree
{
    class BTree
    {

        public int Degree { get; private set; }

        public Node Root { get; private set; }

        public BTree(int degree)
        {
            this.Degree = degree;
            this.Root = new Node(degree);
        }

        public void Insert(int key) {
            Root.Insert(Root, key);

            


        }
        
        public void Delete() { }

        public void Search(int key) { }

        public void Print() {
            Root.Print();
        }
    }
}

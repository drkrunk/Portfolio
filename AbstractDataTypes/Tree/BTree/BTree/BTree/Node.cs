using System;
using System.Collections.Generic;
using System.Text;

namespace BTree
{
    class Node
    {
        private int degree;
        private int count;

        public List<int> keys;
        public List<Node> pointers;

       
        public Node(int degree)
        {
            this.degree = degree;
            //this.keys = new int[2 * degree - 1];

            this.keys = new List<int>();
            this.pointers = new List<Node>();

            this.count = 0;
        }


        public int Search(int key) {
            return key;
        }

        public void Insert(Node parent, int key) {

            keys.Add(key);
            keys.Sort();

            if (IsKeysFull) Split(parent);
        }

        public void Delete(int key) { }

        public void Split(Node parent){
            Node n1 = new Node(degree);
            Node n2 = new Node(degree);

            int mid =  keys.Count / 2;
            for (int i = 0; i < keys.Count; i++){
                if (i < mid)
                {
                    n1.Insert(this, keys[i]);
                    keys.RemoveAt(i);
                }


                else if (i > mid)
                {
                    n2.Insert(this, keys[i]);
                    keys.RemoveAt(i);
                }
               
            }
     
            parent.Insert(this, keys[mid]);
            keys.RemoveAt(mid);
   
            pointers.Add(n1);
            pointers.Add(n2);

        }


        private int findMedian() {
            return keys[keys.Count / 2];
        }

        public bool IsKeysFull {
            get { return this.keys.Count == (2 * degree - 1); } 
        }

        public bool IsPointersFull
        {
            get { return this.pointers.Count == (2 * degree); }
        }

        public void Print() {


            foreach (var key in keys)
                Console.WriteLine(key);
            

            foreach (var item in pointers)
                item.Print();
            
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace HashMap
{

    //Double Linked List For storage in the hashtable to help with collisons
    class Bucket
    {
        private Node first;

        private int count = 0;

        public Node First { get => first; }

        public bool Empty { get { return first == null; } }

        public int Count { get => count; }

        public void Add(IComparable value)
        {
            Node node = new Node(value);

            if (first == null) { 
                first = node; 
                count++; 
                return; 
            }

            node.Next = first;
            first.Previous = node;

            first = node;
            count++;
        }

        public void Remove(IComparable value)
        {
            Node node = FindNode(value);
            if (node == null) return;

            Node prevNode = node.Previous;
            Node nextNode = node.Next;

            prevNode.Next = nextNode;
            if (nextNode != null)
                nextNode.Previous = prevNode;

            count--;
        }

        public void Clear() { first = null; }

        public IComparable Find(IComparable value)
        {
            Node node = FindNode(value);
            if (node == null) return null;

            return node.Value;
        }

        public IComparable[] ToArray() {
            if (Empty) { return new IComparable[0]; }

            Node currentNode = first;
            IComparable[] result = new IComparable[Count];
            int i = 0;

            while (currentNode != null){
                result[i] = currentNode.Value;
                currentNode = currentNode.Next;
               
                i++;
            }
            return result;
        }

        public void Print()
        {
            Node currentNode = first;

            while (currentNode != null){
                Console.Write(currentNode.Value.ToString() +"|");
                currentNode = currentNode.Next;
            }
        }

        private Node FindNode(IComparable value)
        {
            Node currentNode = first;
            while (currentNode != null){

                if (currentNode.Value.CompareTo(value) == 0)
                    return currentNode;

                currentNode = currentNode.Next;
            }
            return null;
        }

    }
}

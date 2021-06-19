using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace BinaryTree
{

    class BinaryTree
    {
        private Node Root;
        public bool Empty { get { return Root == null; } }


        public bool Contains(int value)
        {
            return search(ref this.Root, value) != null;
        }

        public void Delete(int value)
        {
            deleteNode(ref Root, value);
        }


        public void Insert(int value)
        {
            OnInsert(ref this.Root, value);
        }

        public void Print()
        {
            printInOrder(Root);
            Console.WriteLine("");
        }

        private void printInOrder(Node root)
        {
            if (root != null)
            {
                printInOrder(root.Left);
                Console.Write(root.Value + " ");
                printInOrder(root.Right);
            }
        }

        private Node OnInsert(ref Node nodeToAdd, int value)
        {

            if (nodeToAdd == null)
            {
                nodeToAdd = new Node(value);
                return nodeToAdd;
            }

            if (value < nodeToAdd.Value)
                return OnInsert(ref nodeToAdd.Left, value);

            else if (value > nodeToAdd.Value)
                return OnInsert(ref nodeToAdd.Right, value);

            return nodeToAdd;
        }

        private Node deleteNode(ref Node root, int value)
        {
            if (root == null) 
                return root; 

            if (value < root.Value)
                root.Left = deleteNode(ref root.Left, value);

            else if (value > root.Value)
                root.Right = deleteNode(ref root.Right, value);

            else
            {
                if (root.Left == null) { return root.Right; }
                else if (root.Right == null) { return root.Left; }

                root.Value = findLowestValue(ref root.Right);
                root.Right = deleteNode(ref root.Right, root.Value);

            }

            return root;
        }

        private int findLowestValue(ref Node root)
        {
            int min = root.Value;
            while (root.Left != null)
            {
                min = root.Left.Value;
                root = root.Left;
            }
            return min;
        }

        private Node search(ref Node root, int value)
        {
            if (root == null || root.Value == value)  
                return root; 

            if (value < root.Value) 
                return search(ref root.Left, value); 

            if (value > root.Value)  
                return search(ref root.Right, value); 

            return null;
        }

    }
}

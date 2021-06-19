using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Node
    {
        public Node Left;
        public Node Right;

        public int Value { get; set; }

        public Node(int value){ 
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }

    }
}

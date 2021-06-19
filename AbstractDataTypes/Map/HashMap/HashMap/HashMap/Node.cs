using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace HashMap
{
    //Node for double linked list
    class Node
    {
        public Node Next {get; set; }
        public Node Previous { get; set; }
        public IComparable Value { get; set; }

        public Node(IComparable v) { Value = v; }

        //public static bool equals(Node<T> n1, Node<T> n2) { re}
    }
}

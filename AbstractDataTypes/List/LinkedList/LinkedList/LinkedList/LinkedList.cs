using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Dynamic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace LinkedList
{
    class LinkedList<T>
    {
        private Node<T> first, last;
        private int count = 0;

        public int Count { get => count; }
        public bool Empty { get { return first == null; } }

        public T First { get => first.Data; }
        public T Last { get => last.Data; }

        public LinkedList() { }

        public void Add(T data)
        {
            addAtIndex(count, data);
        }

        public void Add(int index, T data)
        {
            addAtIndex(index, data);
        }

        public void Push(T data)
        {
            addAtIndex(0, data);
        }

        public T Pop()
        {
            return (!Empty) ? removeAtIndex(Count) : default;
        }

        public void Clear()
        {
            first = null;
            count = 0;
        }

        public bool Contians(T data)
        {
            if (Empty) return false;

            Node<T> currentNode = first;

            while (currentNode.Next != null){
                currentNode = currentNode.Next;
                if (currentNode.Data.Equals(data)) return true;
            }

            return currentNode.Data.Equals(data);
        }

        public T Find(T data)
        {
            if (Empty) return default;

            Node<T> currentNode = first;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
                if (currentNode.Data.Equals(data)) return currentNode.Data;
            }

            if (currentNode.Data.Equals(data)) return currentNode.Data;

            return default;
        }

        public T removeAtIndex(int index)
        {
            if (index < 0 || index > Count) { throw new IndexOutOfRangeException(); }
            T result = first.Data;

            //SIZE 1 CASE
            if (count == 1)
            {
                Clear();
                return result;
            }

            //FIRST CASE
            if (index == 0)
            {
                first = first.Next;
                count--;
                return result;
            }


            //MIDDLE CASE
            Node<T> prevNode = first;
            Node<T> currentNode = first;
            int i = 0;
            while (currentNode.Next != null)
            {

                if (i == index)
                {
                    result = currentNode.Data;
                    prevNode.Next = currentNode.Next;
                    count--;
                    return result;
                }

                prevNode = currentNode;
                currentNode = currentNode.Next;

                i++;
            }


            //END CASE
            result = prevNode.Data;
            prevNode.Next = null;
            last = prevNode;
            count--;
            return result;
        }

        private T addAtIndex(int index, T data)
        {
            if (index < 0 || index > Count) { throw new IndexOutOfRangeException(); }
            Node<T> node = new Node<T>(data);
            Node<T> prevNode = first;
            Node<T> currentNode = first;

            //EMPTY CASE
            if (Empty)
            {
                first = node;
                last = node;
                count++;
                return data;
            }

            //FRONT CASE
            if (index == 0)
            {
                node.Next = first;
                first = node;
                count++;
                return data;
            }

            //END CASE
            if (index == count)
            {
                last.Next = node;
                last = node;
                count++;
                return data;
            }


            //INSERT CASE
            int i = 0;
            while (currentNode.Next != null)
            {

                if (i == index)
                {
                    prevNode.Next = node;
                    node.Next = currentNode;
                    count++;
                    return data;
                }

                prevNode = currentNode;
                currentNode = currentNode.Next;

                i++;
            }


            //EDGE CASE
            prevNode.Next = node;
            node.Next = currentNode;
            count++;
            return data;

        }


    }
}

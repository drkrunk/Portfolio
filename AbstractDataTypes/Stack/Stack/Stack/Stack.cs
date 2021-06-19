using System;
using System.Linq.Expressions;

namespace Stack
{

   /*
    LIFO
    */

    class Stack<T> where T:IComparable
    {
        private T[] items;

        public int Size{ get {return items.Length;}}

        public bool Empty { get { return items.Length == 0; } } 

        public Stack() {
            items = new T[0];
        }

        public Stack(T[] array){
            items = array;
        }

        public bool Contains(T value) {
            //Linear Search To keep Example Simple
            for (int i = 0; i < items.Length; i++)
                if (value.CompareTo(items[i]) == 0) return true;

            return false;
        }

        public T Peek() { 
            return items[^1];
        }

        public void Clear() {
            items = new T[0];
        }

        public T Push(T item) {
            Array.Resize<T>(ref items, items.Length + 1);
            items[^1] = item;
            return item; 
        }

        public T Pop() {
            if (items.Length <= 0) { throw new System.InvalidOperationException("Illegal pop on an empty stack."); }

            T item = items[^1];
            Array.Resize<T>(ref items, items.Length - 1);
            return item; 
        }

    }
}

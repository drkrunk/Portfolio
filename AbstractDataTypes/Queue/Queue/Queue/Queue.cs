using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queue
{
    class Queue<T>
    {
        private T[] items;
        public int Size { get { return items.Length; } }
        public bool Empty { get { return items.Length == 0; } }
        public Queue()
        {
            items = new T[0];
        }

        public T Enqueue(T item)
        {
            Array.Resize<T>(ref items, items.Length + 1);

            items[^1] = item;
            return item;
        }

        public T Dequeue()
        {
            if (items.Length <= 0) { throw new System.InvalidOperationException("Illegal dequeue on an empty queue."); }

            T item = items[0];
            items = items.Skip<T>(1).ToArray();
            return item;
        }

        private void ExtendFrontArray(ref T[] array) {
            T[] newItems = new T[items.Length+1];

            int count = 1;
            foreach (T item in this.items) {
                newItems[count++] = item;
            }

            array = newItems;
        }

    }
}

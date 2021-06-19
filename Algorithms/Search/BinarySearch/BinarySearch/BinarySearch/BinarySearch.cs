using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    class BinarySearch
    {
        private int[] array;

        public int Checks { get; set; }

        public BinarySearch(int[] array) {
            this.array = array;
        }

        public bool Search(int num) {
            return (search(num, 0, array.Length) == 1);
        }


        // Complexity: O(log n)
        private int search(int num, int startIndex, int endIndex) {
            int delta = Math.Abs(endIndex - startIndex);

            if (delta <= 1) return -1; 
            
            Checks++;
         
            int checkIndex = startIndex + (delta / 2);
            int value = array[checkIndex];

            if (value == num) return 1; 

            if (value > num) 
                return search(num, startIndex, checkIndex);

            if (value < num)
                return search(num, checkIndex, endIndex); 

            return -1;
        
        }
    }
}

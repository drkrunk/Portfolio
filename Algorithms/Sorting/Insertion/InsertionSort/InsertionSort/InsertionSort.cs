using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace InsertionSort
{
    class InsertionSort
    {

        public void Sort(ref int[] array)
        {

            for (int index = 0; index < array.Length; index++)
            {
                int currentPointer = index;

                while (currentPointer>0 && array[currentPointer-1]>array[currentPointer]){

                    int temp = array[currentPointer];
                    array[currentPointer] = array[currentPointer - 1];
                    array[currentPointer - 1] = temp;

                    currentPointer = currentPointer - 1;
                }
            }
        }
    }
}

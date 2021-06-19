using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    class BubbleSort{
        public void Sort(ref int[] array){
            Boolean swaped = true;
            int indexesDone = 0;

            while (swaped){
                swaped = false;
                for (int currentPointer = 0; currentPointer < array.Length-indexesDone; currentPointer++) {
                    if (currentPointer + 1 < array.Length){
                        if (array[currentPointer] > array[currentPointer + 1]){
                            int temp = array[currentPointer];
                            array[currentPointer] = array[currentPointer + 1];
                            array[currentPointer + 1] = temp;
                            swaped = true;
                        }
                    }
                }
                indexesDone++;
            } 
        }

    }
}

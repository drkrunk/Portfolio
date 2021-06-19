using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
    class QuickSort
    {

        public void Sort(ref  int[] array, int low, int high){
            if (low < high){
                /* pi is partitioning index, arr[pi] is now at right place */
                int partitionIndex = Partition(ref array, low, high);

                // Recursively sort elements before and after partition 
                Sort(ref array, low, partitionIndex - 1);
                Sort(ref array, partitionIndex + 1, high);
            }
        }

        private int Partition(ref int[] array, int low,int high){
            int pivot = array[high];

            // index of smaller element 
            int index = (low - 1);
            for (int pointer = low; pointer < high; pointer++){
                // If current element is smaller than the pivot 
                if (array[pointer] < pivot){
                    index++;
                    // swap arr[i] and arr[j]  
                    Swap(ref array, index, pointer);
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            Swap(ref array, index + 1, high);

            return index + 1;
        }

        private void Swap(ref int[] array, int index1, int index2 ) {
            int temp1 = array[index1];
            array[index1] = array[index2];
            array[index2] = temp1;
        }


    }
}

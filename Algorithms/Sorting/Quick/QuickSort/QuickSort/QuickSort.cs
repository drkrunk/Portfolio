using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
    class QuickSort
    {

        public void Sort(ref  int[] array, int low, int high){
            if (low < high){
				//Set partition index
                int partitionIndex = Partition(ref array, low, high);

                // Sort elements before and after partition 
                Sort(ref array, low, partitionIndex - 1);
                Sort(ref array, partitionIndex + 1, high);
            }
        }

        private int Partition(ref int[] array, int low,int high){
            //smaller element  index
            int index = (low - 1);
			int pivot = array[high];
			
            for (int pointer = low; pointer < high; pointer++){
				
                // If element is smaller than the pivot 	
                if (array[pointer] < pivot){
                    index++;
                    Swap(ref array, index, pointer);
                }
            }

            // swap element at index + 1 and high 
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

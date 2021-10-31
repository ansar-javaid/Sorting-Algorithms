using System;

namespace Sorting_Algorithms.Algorithms
{
    public class BubbleSort
    {
        /// <summary>
        /// <h3>Bubble Sort</h3>
        /// <p>Bubble sort is a sorting algorithm that compares two adjacent elements and swaps them until they are not in the intended order.</p>
        /// <p>Just like the movement of air bubbles in the water that rise up to the surface, each element of the array move to the end in each iteration. Therefore, it is called a bubble sort.</p>
        /// </summary>
        /// <param name="array"></param>
        public void Sort(int[] array)
        {
            for (int count1 = 0; count1 < array.Length; count1++)
            {
                for (int count2 = 0; count2 < array.Length - count1 - 1 ; count2++)
                {
                    if (array[count2] > array[count2+1])
                    {
                        int tempHolder = array[count2];
                        array[count2] = array[count2+1];
                        array[count2+1] = tempHolder;
                    }
                }
            }
            //Printing Array Elements
            foreach (var k in array)
            {
                Console.WriteLine(k);
            }
                
        }
    }
}
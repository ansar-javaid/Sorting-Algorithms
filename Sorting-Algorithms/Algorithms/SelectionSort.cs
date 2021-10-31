using System;

namespace Sorting_Algorithms.Algorithms
{
    public class SelectionSort
    {
        /// <summary>
        /// <h3>Selection Sort</h3>
        /// <p>Selection sort is a sorting algorithm that selects the smallest element from an unsorted list in each iteration and places that element at the beginning of the unsorted list.</p>
        /// </summary>
        /// <param name="array"></param>
        public void Sort(int[] array)
        {
            for (int count1 = 0; count1 < array.Length - 1; count1++)
            {
                int minimum = count1;
                for (int count2 = count1 + 1; count2 < array.Length; count2++)
                {
                    if (array[count2] < array[minimum])
                    {
                        minimum = count2;
                    }
                }

                int tempHolder = array[count1];
                array[count1] = array[minimum];
                array[minimum] = tempHolder;
            }
            //Printing Array Elements
            foreach (var k in array)
            {
                Console.WriteLine(k);
            }
        }
    }
}
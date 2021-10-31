using System;

namespace Sorting_Algorithms.Algorithms
{
    public class InsertionSort
    {
     /// <summary>
     /// <h3>Insertion Sort</h3>
     /// <p>Insertion sort is a sorting algorithm that places an unsorted element at its suitable place in each iteration.</p>
     /// <p>Insertion sort works similarly as we sort cards in our hand in a card game.</p>
     /// <p>We assume that the first card is already sorted then, we select an unsorted card. If the unsorted card is greater than the card in hand, it is placed on the right otherwise, to the left. In the same way, other unsorted cards are taken and put in their right place.</p>
     /// </summary>
     /// <param name="array"></param>
        public void Sort(int[] array)
        {
            for (int count = 1; count < array.Length; count++)
            {
                int tempHolder = array[count];
                int j = count - 1;
                while (j>=0 && tempHolder<array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = tempHolder;
            }
            //Printing Array Elements
            foreach (var k in array)
            {
                Console.WriteLine(k);
            }
        }
    }
}
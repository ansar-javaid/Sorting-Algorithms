using System;
using Sorting_Algorithms.Algorithms;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // InsertionSort insertionSort = new InsertionSort();
            // insertionSort.Sort(new []{9,12,4,1,20,5,3});

            // BubbleSort bubbleSort = new BubbleSort();
            // bubbleSort.Sort(new []{9,12,4,1,20,5,3});

            SelectionSort selectionSort = new SelectionSort();
            selectionSort.Sort(new []{9,12,4,1,20,5,3});


        }
    }
}

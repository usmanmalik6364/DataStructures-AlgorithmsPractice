using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class InsertionSort
    {
        public static void insertionSort(this int[] a)
        {
            //loop through the elements
            for (int i = 0; i < a.Length; i++)
            {
                var key = a[i];
                var j = i - 1;
                while (j >= 0 && a[j]<a[i])
                {
                    a[i + 1] = key;
                    i = i - 1;
                    a[i] = a[i + 1];
                    j++;
                }
            }
        }
    }
}

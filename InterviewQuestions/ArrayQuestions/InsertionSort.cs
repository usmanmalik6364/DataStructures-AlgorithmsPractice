using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions.ArrayQuestions
{
    public static class InsertionSort
    {
        public static void insertionSort(this int[] a)
        {
            Console.WriteLine("Before: ");
            foreach (var item in a)
            {
                Console.Write($"\t {item} ");
            }
            for(int i = 1; i < a.Length; i++)
            {
                var key = a[i];
                var j = i - 1;
                while (j>=0 &&a[j]<key)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = key;
            }
            Console.WriteLine("\nAfter: \n");
            foreach (var item in a)
            {
                Console.Write($"\t {item} ");
            }
        }
    }
}

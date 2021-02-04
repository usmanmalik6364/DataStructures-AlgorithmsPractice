using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions.ArrayQuestions
{
    //sum of 2 elements of array equal to K. 
    public class ArrayPairSum
    {
       public int[] arr;
        public ArrayPairSum(int size)
        {
            arr = new int[size];
        }
        //Output all pairs whose sum is equal to K in a given array.
        public void OutputPairsSum(int k)
        {
            //O(nLogn)
            Array.Sort(arr);
            for (int i = 0, j = arr.Length-1; i <arr.Length/2;)
            {
                if (arr[i] + arr[j] == k) { Console.WriteLine($"Found Pair    {arr[i]} , {arr[j]} \n"); i++;j--; } 
                else if (arr[i] + arr[j] > k) j--;
                else if (arr[i] + arr[j] < k) i++;
                if (i == j) break;
            }
        }
        public void OutputPairsSumQuadtraticTime(int k)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = i+1; j<arr.Length - 1; j++)
                {
                    if(arr[i]+arr[j]==k) Console.WriteLine($"Found Pair    {arr[i]} , {arr[j]} \n");
                }
            }
        }
        public void PairSumLinearTime(int k)
        {
            HashSet<int> s = new HashSet<int>();
            for (int i = 0; i < arr.Length; ++i)
            {
                int temp = k - arr[i]; //12-3 = 9

                // checking for condition
                if (s.Contains(temp)) //9
                {
                    Console.Write("Pair with given sum " +
                    k + " is (" + arr[i] + ", " + temp + ") \n");
                }
                s.Add(arr[i]);
            }
        }
    }
}

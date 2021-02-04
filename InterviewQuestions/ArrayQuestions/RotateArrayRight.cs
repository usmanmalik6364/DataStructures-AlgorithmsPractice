using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions.ArrayQuestions
{

    public static class RotateArrayRight
    {
       
        //Given an array, rotate the array to the right by k steps, where k is non-negative.
        //Contraints 
        //Try to come up as many solutions as you can, there are at least 3 different ways to solve this problem.
        //Could you do it in-place with O(1) extra space?

        //Solution is the following
        public static void Rotate(this int[] nums, int k)
        {
            Console.WriteLine("Array After Rotation is \n");
            Console.Write("{ ");
            foreach (var item in nums)
            {
                Console.Write("  " + item );
            }
            Console.Write("  }" );

            if (k == 0 || (nums.Length < 2)) return;
            k = k % nums.Length;
            rotate(nums, 0, nums.Length - 1);
            rotate(nums, k, nums.Length - 1);
            rotate(nums, 0, k - 1);
            Console.WriteLine("Array After Rotation is \n");
            Console.Write("{ ");
            foreach (var item in nums)
            {
                Console.Write("  "+item );
            }
            Console.Write("  }");

        }
        public static void rotate( int[] a, int start, int end)
        {
            for (int i = start, j = end; i < j; i++, j--)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
        }
    }
}

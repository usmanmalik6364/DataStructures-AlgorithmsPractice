using SortingAlgorithms.DataStructures;
using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 2, 5, 1, 3, 4, 7 };
            var n = 3;
            var new_arr = new int[nums.Length];
            //need three pointers
            // i for traversal,
            //x for x1,x2,...xn
            //y for y1,y2,y3...yn
            for (int i = 0, x = 0, y = n; i < nums.Length; i++)
            {
                
                if (y >= nums.Length) break;
                if (i == 0)
                {
                    new_arr[i] = nums[x];
                    continue;
                }
                if (i == 1)
                {
                    new_arr[i] = nums[y];
                    continue;
                }

                if (i % 2 == 0)
                {
                    x++;
                    new_arr[i] = nums[x]; 
                }
                else
                {
                    if (y < nums.Length)
                    {
                        y++;
                        new_arr[i] = nums[y];
                    }
                }

            }
            foreach (var item in new_arr)
            {
                Console.WriteLine(item);
            }


            //TestDynamicArrays
            //DynamicArrays();
        }
        static void DynamicArrays()
        {
            DynamicArrays<int> test = new DynamicArrays<int>(2);
            for(int i = 0; i< 5; i++)
            {
                test.add(i);
            }
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Index of 0 => "+ test.indexOf(0));
            Console.WriteLine("\r\n");
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
        }
    }
}

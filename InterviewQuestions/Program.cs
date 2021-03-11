using InterviewQuestions.ArrayQuestions;
using InterviewQuestions.StringQuestions;
using SortingAlgorithms.DataStructures;
using System;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack < Int64 > TestStack = new Stack<Int64>();
            for (int i = 0; i < 10; i++)
            {
                TestStack.push(i);
            }
            TestStack.pop();
            foreach (var item in TestStack)
            {
                Console.WriteLine(item);
            }
        }
        public static void testInsertionSort()
        {
            var a = new int[6]{ 5,2,4,6,1,3};
            a.insertionSort();
        }
       
        public static void testRotate()
        {
            var nums = new int[7] { 1, 2, 3,4,5,6,7 };
            nums.Rotate(3); //k=3;
        }
        public static  void testArrayPairSumOnLogn()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            ArrayPairSum a = new ArrayPairSum(100000000);
            for (int i = 0; i < 100000000; i++)
            {
                a.arr[i] = i + 2;
            }
            //lets say k == 12
            a.OutputPairsSum(12);
            Console.WriteLine($"Execution Time O(nLogn): {watch.ElapsedMilliseconds} ms");
        }
        public static void testOutputPairsSumQuadtraticTime()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            ArrayPairSum a = new ArrayPairSum(100000000);
            for (int i = 0; i < 100000000; i++)
            {
                a.arr[i] = i + 2;
            }
            //lets say k == 12
            a.OutputPairsSumQuadtraticTime(12);
            Console.WriteLine($"Execution Time (O(npower2): {watch.ElapsedMilliseconds} ms");
        }
        public static void testOutputPairsLinearTime()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            ArrayPairSum a = new ArrayPairSum(100000000);
            for (int i = 0; i < 100000000; i++)
            {
                a.arr[i] = i + 2;
            }
            //lets say k == 12
            a.PairSumLinearTime(12);
            Console.WriteLine($"Execution Time (O(Logn): {watch.ElapsedMilliseconds} ms");
        }
        public static void testStringIsUnique()
        {
            string s = "abcdefghijklmnopqrstua";

            if (s.isUnique()) Console.WriteLine("\nS Contains Unique Characters \n");
            else Console.WriteLine("\nS Does not contain unique characters \n");

        }
        public static void testStringPermutation()
        {
            string a = "ABC";
            string b = "CAB";
            if (a.isPermutation(b)) Console.WriteLine("A is Permutation of B\n");
            else Console.WriteLine("A is not permutation of B\n");
        }
        public static void testStringURLify()
        {
            string a = "My Name is Usman.";
            a = a.URLify();
            Console.WriteLine(a);
        }
        public static void testisPalindrome()
        {
            string test = "teste";
            if (test.isPalindrome()) Console.WriteLine("Yes it is a palindrome");
            else Console.WriteLine("No, it is not a palindrome");
        }
    }
}

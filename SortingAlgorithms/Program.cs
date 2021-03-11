using SortingAlgorithms.DataStructures;
using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Int64> TestStack = new Stack<Int64>();
            for (int i = 0; i < 10; i++)
            {
                TestStack.push(i);
            }
            foreach (var item in TestStack)
            {
                Console.WriteLine(item);
            }
        }
        public static void GreetingHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        public static void GreetingHello(int name)
        {
            Console.WriteLine($"Hello {name}");
        }

        static void DynamicArrays()
        {
            DynamicArrays<int> test = new DynamicArrays<int>(2);
            for (int i = 0; i < 5; i++)
            {
                test.add(i);
            }
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Index of 0 => " + test.indexOf(0));
            Console.WriteLine("\r\n");
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
        }
    }
}

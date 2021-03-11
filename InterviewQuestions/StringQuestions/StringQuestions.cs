using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions.StringQuestions
{
    /// <summary>
    /// This class contains some common string questions and there solutions
    /// </summary>
    public static class StringQuestions
    {

        public static Boolean isUnique(this string input)
        {
            //assuming that the string is in ascii characters. The unique characters will be no more than 128 so.
            if (input.Length > 128) return false;
            bool[] char_set = new bool[128];
            for (int i = 0; i < input.Length; i++)
            {
                int value = input[i];
                if (char_set[value]) return false;
                char_set[value] = true;
            }
            return true;
        }
        public static Boolean isPermutation(this string input, string input2)
        {
            if (input.Length != input2.Length)
                return false;
            var charArrayInput1 = input.ToCharArray();
            var charArrayInput2 = input2.ToCharArray();
            Array.Sort(charArrayInput1);
            Array.Sort(charArrayInput2);
            var stringInput1 = new string(charArrayInput1);
            var stringInput2 = new string(charArrayInput2);
            if (!stringInput1.Equals(stringInput2)) return false;
            else
                return true;
        }
        public static string URLify(this string input)
        {
            //input "My Name is Usman."
            //Output "My%20Name%20is%20Usman."
            //int spaceCount = 0, index, i = 0;
            int spaceCount = 0, index = 0, i = 0;

            for (i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ') spaceCount++;
            }
            index = input.Length + spaceCount * 2;
            var charset = new char[index];
            for (i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == ' ')
                {
                    charset[index - 1] = '0';
                    charset[index - 2] = '2';
                    charset[index - 3] = '%';
                    index = index - 3;
                }
                else
                {
                    charset[index - 1] = input[i];
                    index--;
                }
            }

            return input = new string(charset);
        }
        public static Boolean isPalindrome(this string input)
        {
            //racecar 
            //notice every character occurs twice or more except for one
            //maintain an int array for keeping the count of every character that occurs in string
            int[] CharCounts = new int[128];
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int value = input[i];
                CharCounts[value]++;
            }
            for (int i = 0; i < 128; i++)
            {
                count += CharCounts[i] % 2;
            }
            return count <= 1;
        }
    }
}

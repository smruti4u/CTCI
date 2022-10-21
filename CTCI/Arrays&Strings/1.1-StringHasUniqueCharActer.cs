using System;
using CTCI.Common;

namespace CTCI.ArraysStrings
{
    /*
     Determine an algorithm to check if string has all unique characters

       Input - aab   output - false
       Input - abc     output - true

     */
    public class StringHasUniqueCharacters : Question
    {

        // Using hash table
        public bool UsingExtraSpace(string s)
        {
            s = s.ToLower();
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach(char c in s)
            {
                if(map.ContainsKey(c))
                {
                    return false;
                }
                else
                {
                    map.Add(c, 1);
                }
            }

            return true;
        }

        /* Sort The String . Enumerate Over the string to find duplicatye
           Time Complexity =    Sorting + ArrayIteration
                                O(n(logn) + n) = O(n(logn))
         */
        public bool NotUsingExtraSpace(string s)
        {
            var c = s.ToCharArray();
            Array.Sort(c);
            var temp = c[0];
            for(int i=1; i< c.Length; i++)
            {
                if (c[i] == temp)
                {
                    return false;
                }
                else
                {
                    temp = c[i];
                }
            }

            return true;
        }

        public void Run()
        {
            var input1 = "abc"; var input2 = "aabc";
            Console.WriteLine($"Input {input1} : {this.UsingExtraSpace(input1)}  {this.NotUsingExtraSpace(input1)}");
            Console.WriteLine($"Input {input2} : {this.UsingExtraSpace(input2)}  {this.NotUsingExtraSpace(input2)}");

        }
    }
}


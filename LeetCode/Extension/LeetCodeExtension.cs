using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Extension
{
    internal static class LeetCodeExtension
    {
        public static void Dummy(this int input)
        {
            Console.WriteLine(input);
        }

        public static void Dummy(this int[] input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
        
        public static void Dummy(this IList<string> input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }

        public static void Dummy(this string input)
        {
            Console.WriteLine(input);
        }
    }
}

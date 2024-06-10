using net.entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.cn/problems/longest-substring-without-repeating-characters/description/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            if(s== string.Empty) return 0;
            var ans = 1;
            var dict = new Dictionary<char, int>();

            dict.Add(s[0], 0);
            var left = 0;
            for (var i = 1; i < s.Length; i++)
            {
                if (!dict.TryGetValue(s[i], out int value))
                {
                    dict.Add(s[i], i);
                }
                else
                {
                    ans = Math.Max(ans, i - left);
                    left = Math.Max(left, value + 1);
                    dict[s[i]] = i;
                }

            }

            return Math.Max(ans, s.Length - left);

        }

        public void Test0003()
        {
            var input = "abcabcbb";
            var output = LengthOfLongestSubstring(input);
            Console.WriteLine(output);
        }
    }
}

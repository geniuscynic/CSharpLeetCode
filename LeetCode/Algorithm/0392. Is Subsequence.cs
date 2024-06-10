using LeetCode.Extension;
using net.entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Algorithm
{
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.cn/problems/is-subsequence/solutions/
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsSubsequence(string s, string t)
        {
            if(s.Length == 0) return true;
            if(s.Length > t.Length) return false;

            int i = 0, j = 0;
            while(i < s.Length && j < t.Length) 
            {
                if (s[i] == t[j])
                {
                    i++;
                }

                j++;
            }

            return i == s.Length;
        }

        public bool IsSubsequence0392(string s, string t)
        {
            if (s.Length == 0) return true;
            if (s.Length > t.Length) return false;

            int left = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (s[left] == t[i])
                {
                    left++;

                    if (left == s.Length)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void Test0392()
        {
            var input = 5;
            var outputs = CountBits(input);
            outputs.Dummy();
           
        }
    }
}

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
        /// https://leetcode.cn/problems/counting-bits/description/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] CountBits(int n)
        {
            var bits = new int[n + 1];
            for (var i = 1; i <= n; i++)
            {
                bits[i] = bits[i & (i-1)] + 1;
            }

            return bits;
        }

        public int[] CountBits0338_3(int n)
        {
            var bits = new int[n + 1];
            for (var i = 1; i <= n; i++)
            {
                bits[i] = bits[ i >> 1] + (i & 1);
            }

            return bits;
        }

        public int[] CountBits0338_2(int n)
        {
            var bits = new int[n + 1];
            var highBit = 0;
            for (var i = 1; i <= n; i++)
            {
                if ((i & (i - 1)) == 0)
                {
                    highBit = i;
                    bits[i] = 1;
                }
                else
                {
                    bits[i] = bits[i - highBit] + 1;
                }

            }

            return bits;
        }

        public int[] CountBits0338_1(int n)
        {
            var ans = new int[n + 1];
            for(var i =0; i <= n; i++)
            {
                ans[i] = GetBits(i);
            }

            return ans;
        }

        private int GetBits(int n) {
            var bits = 0;
            while(n > 0)
            {
                n &= (n - 1);
                bits++;
            }

            return bits;
        }

        public void Test0338()
        {
            var input = 5;
            var outputs = CountBits(input);
            outputs.Dummy();
           
        }
    }
}

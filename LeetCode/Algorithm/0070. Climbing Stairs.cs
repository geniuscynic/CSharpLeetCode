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
        /// https://leetcode.cn/problems/climbing-stairs/description/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int ClimbStairs(int n)
        {
            var first = 1; 
            var second = 2;
            for(var i = 2; i < n; i++)
            {
                var sum = first + second;
                first =second;
                second = sum;
            }

            return second;
        }

        public int ClimbStairs70_1(int n)
        {
            return ClimbStairs70_1(n, []);
        }

        private int ClimbStairs70_1(int n, Dictionary<int, int> dp)
        {
            if (n <= 2) return n;

            if(dp.TryGetValue(n, out int value))
            {
                return value;
            }

            var res = ClimbStairs70_1(n-1, dp) + ClimbStairs70_1(n-2, dp);
            dp.Add(n, res);

            return res;
                     
        }
    }
}

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
        /// https://leetcode.cn/problems/divisor-game/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool DivisorGame(int n)
        {
            return (n & 1) == 0;
        }

        public void Test1025()
        {
            var input = new int[]{ 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
            var outputs = MinCostClimbingStairs(input);
            outputs.Dummy();
           
        }
    }
}

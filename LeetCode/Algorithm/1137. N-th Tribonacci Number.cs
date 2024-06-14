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
        /// https://leetcode.cn/problems/n-th-tribonacci-number/description/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Tribonacci(int n)
        {
            if (n < 2) return n;

            int t0 = 0, t1 = 1, t2 = 1;
            
            for (var i = 2; i < n; i++)
            {
                (t0, t1, t2) = (t1, t2, t0 + t1 + t2);
            }

            return t2;
        }

        public void Test1137()
        {
            var input = 4;
            var outputs = Tribonacci(input);
            outputs.Dummy();
           
        }
    }
}

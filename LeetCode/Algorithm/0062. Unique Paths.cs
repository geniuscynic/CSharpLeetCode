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
        public int UniquePaths(int m, int n)
        {
            var dp = new int[m, n];
            return UniquePaths(m - 1, n - 1, dp);
        }
        
        private int UniquePaths(int m, int n, int[,] dp)
        {
            if (m == 0) return 0;
            if (n == 0) return 0;
            
            if(dp[m, n] != 0) return dp[m, n];
            
            var res = UniquePaths(m - 1, n, dp) + UniquePaths(m, n - 1, dp);
            dp[m, n] = res;
            return res;
        }
        
        public void Test0062()
        {
            var input = 3;
            var input2 = 7;
            var outputs = UniquePaths(input, input2);
            outputs.Dummy();
        }
    }
}
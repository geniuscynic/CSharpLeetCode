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
        public int MinCostClimbingStairs(int[] cost)
        {
            var first = 0;
            var second = 0;
            for(int i = 1; i < cost.Length; i++)
            {
                var t1 = first + cost[i-1];
                var t2 = second + cost[i];
                var sum = Math.Min(t1, t2);

                //$"{i}:{first}:{second}:{sum}".Dummy();

                first = second;
                second = sum;

               
            }

            return second;
        }

        public int MinCostClimbingStairs0746(int[] cost)
        {
            int[] dp = new int[cost.Length + 1];
            Array.Fill(dp, -1);
            return MinCostClimbingStairs(cost, cost.Length, dp);
        }

        private int MinCostClimbingStairs(int[] cost, int n, int[] dp)
        {
            if(n <= 1) return 0;

            if (dp[n] >= 0) return dp[n];

            var c1 = MinCostClimbingStairs(cost, n - 1, dp) + cost[n - 1];
            var c2 = MinCostClimbingStairs(cost, n - 2, dp) + cost[n - 2];
            dp[n] = Math.Min(c1, c2);
            return dp[n];
        }

        public void Test0746()
        {
            var input = new int[]{ 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
            var outputs = MinCostClimbingStairs(input);
            outputs.Dummy();
           
        }
    }
}

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
        /// https://leetcode.cn/problems/best-time-to-buy-and-sell-stock/description/
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {
            var minProfit = int.MaxValue;
            var ans = 0;

            for(var i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minProfit) minProfit = prices[i];
                else ans = Math.Max(ans, prices[i] - minProfit);
            }

            return ans;
        }

        public int MaxProfit0121(int[] prices)
        {
            var left = 0;
            var ans = 0;

            for (var i = 0; i < prices.Length; i++)
            {
                if (prices[i] < prices[left])
                {
                    left++;
                    while (left <= i && prices[i] < prices[left])
                    {
                        left++;
                    }
                }
                else
                {
                    ans = Math.Max(ans, prices[i] - prices[left]);
                }
            }

            return ans;
        }

        public void Test0121()
        {
            var input = new []{ 2, 1, 2, 1, 0, 1, 2 };
            var outputs = MaxProfit(input);
            Console.WriteLine(outputs);
           
        }
    }
}

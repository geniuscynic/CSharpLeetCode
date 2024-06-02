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
        /// 1. Two Sum
        /// https://leetcode.com/problems/two-sum/description/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for(var i = 0; i < nums.Length;  i++)
            {
                if(dict.ContainsKey(target - nums[i])) 
                {  
                    return [i, dict[target - nums[i]]];
                }

                dict.TryAdd(nums[i], i);
            }

            return [0, 1];
        }
    }
}

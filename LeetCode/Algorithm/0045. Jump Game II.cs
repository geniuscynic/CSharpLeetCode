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
        /// https://leetcode.cn/problems/jump-game-ii/description/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int Jump(int[] nums)
        {
            var pos = 0;
            var step = 0;
            var maxPos = 0;
            for(var i = 0; i < nums.Length; i++)
            {
                maxPos = Math.Max(maxPos, i + nums[i]);
                if (i == pos)
                {
                    pos = maxPos;
                    step++;
                }
            }
            
            return  step;
        }
        
        public int Jump0045(int[] nums)
        {
            var pos = 0;
            var step = 0;
            
            while (pos < nums.Length - 1) 
            {
                step++;
                if (pos + nums[pos] >= nums.Length-1)
                {
                    return step;
                }
                var ans = 0;
                var next = 0;
                for (var i = pos + 1; i <= pos + nums[pos]; i++)
                {
                    if (i + nums[i] >= nums.Length-1)
                    {
                        return step+1;
                    }
                    
                    if (ans < i + nums[i])
                    {
                        ans = i+ nums[i];
                        next = i;
                    }
                }

                pos = next;   
            }
            
            return  step;
        }
        
        public void Test0045()
        {
            var input = new []{1,2};
            var input2 = "a";
            var outputs = Jump(input);
            outputs.Dummy();
        }
    }
}
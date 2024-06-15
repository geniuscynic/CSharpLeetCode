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
        /// https://leetcode.cn/problems/unique-paths-ii/solutions/
        /// </summary>
        /// <param name="obstacleGrid"></param>
        /// <returns></returns>
        public int UniquePathsWithObstacles(int[][] obstacleGrid) {
            var step = new int[obstacleGrid.Length, obstacleGrid[0].Length];
            for (var i = 0; i < obstacleGrid.Length; i++)
            {
                if (obstacleGrid[i][0] == 0)
                {
                    step[i, 0] = 1;
                }
                else
                {
                    break;
                }
            }
            
            for (var i = 0; i <  obstacleGrid[0].Length; i++)
            {
                if (obstacleGrid[0][i] == 0)
                {
                    step[0, i] = 1;
                }
                else
                {
                    break;
                }
            }
            
            for (var i = 1; i < obstacleGrid.Length; i++)
            {
                for (var j = 1; j < obstacleGrid[0].Length; j++)
                {
                    if (obstacleGrid[i][j] == 0)
                    {
                        step[i, j] = step[i - 1, j] + step[i, j - 1];
                    }
               }
           }
            
            return  step[obstacleGrid.Length - 1, obstacleGrid[0].Length - 1];
        }
        
       
        
        public void Test0063()
        {
            var input = new [] {
                [0,0,0,1,0,0,0,0,0,1,0,0],
                [0,0,1,0,0,0,0,0,0,0,0,0],
                [1,0,0,1,0,0,0,0,0,1,0,0],
                [1,0,0,0,0,0,0,0,0,0,0,0],
                [0,0,0,1,0,0,0,0,0,0,0,1],
                [0,0,1,0,0,0,1,1,0,0,1,0],
                [0,0,0,0,0,0,1,0,0,0,1,1],
                [1,1,0,0,0,0,0,0,0,0,0,0],
                [0,0,0,0,1,0,0,1,0,1,1,1],
                new []
                
                    {0,0,0,1,0,0,0,0,0,0,0,0},
               
                };
            var input2 = 7;
            var outputs = UniquePathsWithObstacles(input);
            outputs.Dummy();
        }
    }
}
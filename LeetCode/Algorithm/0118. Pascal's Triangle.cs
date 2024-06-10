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
        /// https://leetcode.cn/problems/pascals-triangle/solutions/2784222/jian-dan-ti-jian-dan-zuo-pythonjavaccgoj-z596/
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public IList<IList<int>> Generate(int numRows)
        {
            var res = new List<IList<int>>();
            for (var i = 0; i < numRows; i++)
            {
                var row = new List<int>();
                for (var j = 0; j <= i; j++)
                {
                    if(j == 0 || j ==  i) row.Add(1);
                    else row.Add(res[i - 1][j - 1] + res[i - 1][j]);
                }

                res.Add(row);
            }

            return res;
        }

        public IList<IList<int>> Generate0118(int numRows)
        {
            var res = new List<IList<int>>();
            for (var i = 0; i < numRows; i++)
            {
                var row = new List<int>();
                row.Add(1);
                var middle = i >> 1;
                for (var j = 1; j <= middle; j++)
                {
                    var current = res[i - 1][j - 1] + res[i - 1][j];
                    row.Add(current);
                }

                for (var j = middle - (((i + 1) & 1)); j >= 0; j--)
                {
                    row.Add(row[j]);
                }

                res.Add(row);
            }

            return res;
        }

        public void Test0118()
        {
            var input = 50;
            var outputs = Generate(input);
           foreach (var output in outputs)
            {
                foreach(var row in output)
                {
                    Console.Write(row + " ,");
                }

                Console.WriteLine();
            }
           
        }
    }
}

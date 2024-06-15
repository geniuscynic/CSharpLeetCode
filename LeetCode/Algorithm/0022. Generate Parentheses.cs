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
        /// https://leetcode.cn/problems/generate-parentheses/description/
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public IList<string> GenerateParenthesis(int n)
        {
            var list = new List<string>();
            
            GenerateParenthesis(new StringBuilder(), list, n, n);

            return list;
        }

        private void GenerateParenthesis(StringBuilder sb, List<string> res, int left, int right)
        {
            if (left < 0 || right < 0 || left > right)
            {
                return;
            }

            if (left == 0 && right == 0)
            {
                res.Add(sb.ToString());
                return;
            }
            
            sb.Append('(');
            GenerateParenthesis(sb, res, left - 1, right);
            sb.Remove(sb.Length - 1, 1);
            
            sb.Append(')');
            GenerateParenthesis(sb, res, left, right - 1);
            sb.Remove(sb.Length - 1, 1);
        }

        public void Test0022()
        {
            var input = 4;
            var input2 = "a";
            var outputs = GenerateParenthesis(input);
            outputs.Dummy();
        }
    }
}
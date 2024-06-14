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
        /// https://leetcode.cn/problems/maximum-repeating-substring/description/
        /// </summary>
        /// <param name="sequence"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public int MaxRepeating(string sequence, string word)
        {
            //var res = 0;
            var seqSpan = sequence.AsSpan();
            var wordSpan = word.AsSpan();

            var res = new int[sequence.Length + seqSpan.Length];
            for (var i = 0; i<= seqSpan.Length - wordSpan.Length; i++)
            {
                    if (Equal(i, seqSpan, wordSpan))
                    {
                        res[i+wordSpan.Length] = res[i]+ 1;
                    }
                   
               
            }

            return res.Max();
        }
        
        public int MaxRepeating1668(string sequence, string word)
        {
            var res = 0;
            var seqSpan = sequence.AsSpan();
            var wordSpan = word.AsSpan();

            for (var i = 0; i<= seqSpan.Length - wordSpan.Length; i++)
            {
                var tmp = i;
                var ans = 0;
                while (tmp <= seqSpan.Length - wordSpan.Length)
                {
                    if (Equal(tmp, seqSpan, wordSpan))
                    {
                        tmp += wordSpan.Length;
                        ans++;     
                    }
                    else
                    {
                        break;
                    }
                   
                }
                res = Math.Max(res, ans);
            }

            return res;
        }

        private bool Equal(int start, ReadOnlySpan<char> seqSpan, ReadOnlySpan<char> wordSpan)
        {
            for (var i = start; i < seqSpan.Length  &&  i - start < wordSpan.Length; i++)
            {
                if (seqSpan[i] != wordSpan[i - start])
                {
                    return false;
                }
            }
            return  true;
        }
        
        public void Test1668()
        {
            var input = "a";
            var input2 = "a";
            var outputs = MaxRepeating(input, input2);
            outputs.Dummy();
        }
    }
}
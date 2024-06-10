using net.entity;
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
    // todo 
    public partial class Solution
    {
        private Dictionary<string, bool> dp = new Dictionary<string, bool>();
        public string LongestPalindrome(string s)
        {
            var span = s.AsSpan();
            int left = 0, right = 0;
            for (var i = 0; i < span.Length - 1; i++)
            {
                for (var j = 1; j < span.Length; j++)
                {
                    if (CheckLongestPalindrome(i, j, span))
                    {
                        if (j - i > right - left)
                        {
                            left = i;
                            right = j;
                        }
                    }
                }
            }

            return span[left..(right + 1)].ToString();
        }

        private bool CheckLongestPalindrome(int left, int right, ReadOnlySpan<char> s)
        {
            var key1 = $"{left}:{right}";
            while (left < right) 
            {
                var key = $"{left}:{right}";
                if (dp.TryGetValue(key, out bool value))
                {
                    return value;
                }

                if (s[left] != s[right])
                {
                    dp.Add(key, false);
                    return false;
                }
                left++;
                right--;
            }

            
            dp.Add(key1, true);
            return true;
        }

        public void Test0005()
        {
            var input = "gphyvqruxjmwhonjjrgumxjhfyupajxbjgthzdvrdqmdouuukeaxhjumkmmhdglqrrohydrmbvtuwstgkobyzjjtdtjroqpyusfsbjlusekghtfbdctvgmqzeybnwzlhdnhwzptgkzmujfldoiejmvxnorvbiubfflygrkedyirienybosqzrkbpcfidvkkafftgzwrcitqizelhfsruwmtrgaocjcyxdkovtdennrkmxwpdsxpxuarhgusizmwakrmhdwcgvfljhzcskclgrvvbrkesojyhofwqiwhiupujmkcvlywjtmbncurxxmpdskupyvvweuhbsnanzfioirecfxvmgcpwrpmbhmkdtckhvbxnsbcifhqwjjczfokovpqyjmbywtpaqcfjowxnmtirdsfeujyogbzjnjcmqyzciwjqxxgrxblvqbutqittroqadqlsdzihngpfpjovbkpeveidjpfjktavvwurqrgqdomiibfgqxwybcyovysydxyyymmiuwovnevzsjisdwgkcbsookbarezbhnwyqthcvzyodbcwjptvigcphawzxouixhbpezzirbhvomqhxkfdbokblqmrhhioyqubpyqhjrnwhjxsrodtblqxkhezubprqftrqcyrzwywqrgockioqdmzuqjkpmsyohtlcnesbgzqhkalwixfcgyeqdzhnnlzawrdgskurcxfbekbspupbduxqxjeczpmdvssikbivjhinaopbabrmvscthvoqqbkgekcgyrelxkwoawpbrcbszelnxlyikbulgmlwyffurimlfxurjsbzgddxbgqpcdsuutfiivjbyqzhprdqhahpgenjkbiukurvdwapuewrbehczrtswubthodv";
            var output = LongestPalindrome(input);
            Console.WriteLine(output);
        }
    }
}

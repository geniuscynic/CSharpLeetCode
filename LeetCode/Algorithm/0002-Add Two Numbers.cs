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
    public partial class Solution
    {
        /// <summary>
        /// https://leetcode.cn/problems/add-two-numbers/description/
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var tail = new ListNode();
            var header = tail;
            var carry = 0;
            var sum = 0;
            while (l1 != null || l2 != null || carry == 1) {
                sum = (l1?.val??0) + (l2?.val??0 )+ carry;
                carry = sum / 10;

                tail.next = new ListNode(sum % 10);
                tail = tail.next;
                l1 = l1?.next;
                l2 = l2?.next;
            }

            return header.next;
        }
    }
}

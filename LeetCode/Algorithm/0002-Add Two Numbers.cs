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
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = new ListNode();
            var header = result;
            var digit = 0;
            var res = 0;
            while (l1 != null || l2 != null || digit == 1) {
                if(l1 != null)
                {
                    res += l1.val;
                }
                if(l2 != null)
                {
                    res += l2.val;
                }
              
                res += digit;
                if(res >= 10)
                {
                    digit = 1;
                    res -= 10;
                }
                else
                {
                    digit = 0;
                }

                result.next = new ListNode(res);
                res = 0;
                result = result.next;
                l1 = l1?.next;
                l2 = l2?.next;
            }



            return header.next;
        }
    }
}

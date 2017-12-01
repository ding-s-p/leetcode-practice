using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _24_SwapPairs
    {
        public static ListNode run(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode f = head.next, a = head, b = a.next, pre = null;
            while (b != null)
            {
                a.next = b.next;
                b.next = a;
                if (pre != null)
                {
                    pre.next = b;
                }
                if (a.next == null || a.next.next == null)
                {
                    break;
                }
                pre = a;
                a = a.next;
                b = a.next;
            }

            return f;
        }
    }
}

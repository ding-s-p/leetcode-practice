using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _25_ReverseKGroup
    {
        public static ListNode run(ListNode head, int k)
        {
            if (head == null || head.next == null || k <= 1)
            {
                return head;
            }

            ListNode a = head, b = head.next, r = a.next;
            while (true)
            {
                a.next = null;
                for (int i = 0; i < k - 1; i++)
                {
                    r = r.next;
                    b.next = a;
                    a = b;
                    b = r;
                    if (r == null)
                    {
                        break;
                    }
                }
                head.next = r;
            }

            return a;
        }
    }
}

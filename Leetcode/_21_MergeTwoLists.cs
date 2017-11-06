using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _21_MergeTwoLists
    {
        public static ListNode run(ListNode l1, ListNode l2)
        {
            ListNode l = new ListNode();
            ListNode filrst = l;
            while (l1 != null || l2 != null)
            {
                if (l1.val < l2.val)
                {
                    l.next = l1;
                    l = l.next;
                    l1 = l1.next;
                }
                else
                {
                    l.next = l2;
                    l = l.next;
                    l2 = l2.next;
                }
                if (l1 == null)
                {
                    l.next = l2;
                    break;
                }
                if (l2 == null)
                {
                    l.next = l1;
                    break;
                }
            }

            filrst = filrst.next;
            return filrst;
        }
    }
}

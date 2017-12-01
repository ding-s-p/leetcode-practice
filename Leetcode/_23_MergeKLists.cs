using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _23_MergeKLists
    {
        public static ListNode run(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0)
            {
                return null;
            }
            ListNode l = new ListNode(0);
            ListNode filrst = l;
            int m = 0;
            int count = 0;
            while (true)
            {
                ListNode mark = null;
                for (int i = 0; i < lists.Length; i++)
                {
                    if (lists[i] != null)
                    {
                        if (mark == null)
                        {
                            mark = lists[i];
                            m = i;
                        }
                        else if (mark.val >= lists[i].val)
                        {
                            mark = lists[i];
                            m = i;
                        }
                    }
                }
                if (l != null)
                {
                    l.next = mark;
                    l = l.next;
                }
                if (lists[m] != null)
                {
                    lists[m] = lists[m].next;
                }
                
                if (lists[m] == null)
                {
                    count++;
                }
                if (count == lists.Length)
                {
                    break;
                }
            }

            filrst = filrst.next;
            return filrst;
        }
    }
}

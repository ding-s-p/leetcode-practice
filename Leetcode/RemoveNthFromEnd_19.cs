using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class RemoveNthFromEnd_19
    {
        public static ListNode run(ListNode head, int n)
        {
            if (head.next == null)
            {
                return null;
            }
            ListNode first = head;
            ListNode delete = head;

            for (int i = 0; i < n; i++)
            {
                head = head.next;
            }

            if (head == null)
            {
                first = first.next;
            }

            while (head != null && head.next != null)
            {
                head = head.next;
                delete = delete.next;
            }

            delete.next = delete.next.next;

            return first;
        }

    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public ListNode() { }

        public static ListNode Create(int[] a)
        {
            ListNode head = new ListNode(a[0]);
            if (a.Length > 1)
            {

                head.next = new ListNode(a[1]);
                ListNode item = head.next;
                for (int i = 2; i < a.Length; i++)
                {
                    item.next = new ListNode(a[i]);
                    item = item.next;
                }
            }

            return head;
        }

        public static string print(ListNode head)
        {
            string a = "";
            while (head != null)
            {
                a += head.val + " -> ";
                head = head.next;
            }
            a += "null";
            Console.WriteLine(a);
            return a;
        }
    }


}

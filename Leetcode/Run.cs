using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class Run
    {
        public static void Main(string[] args)
        {
            var l1 = ListNode.Create(new int[] { -9, 3 });
            var l2 = ListNode.Create(new int[] { 5, 7 });
            var res = _21_MergeTwoLists.run(l1, l2);
            ListNode.print(res);
            // Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

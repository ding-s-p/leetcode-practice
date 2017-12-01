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
            var m = new int[] { 1 };
            var res = _35_SearchInsert.run(m, 0);
            //ListNode.print(res);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

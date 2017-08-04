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
            var res = ThreeSum_15.run(new int[] { -1, 0, 1, 2, -1, -4 });
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

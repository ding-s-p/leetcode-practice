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
            int[] digits = new int[] { 1, 2, 3, 1 };
            var res = _198_Rob1.run(digits);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}

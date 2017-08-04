using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class PalindromeNumber_9
    {
        public static bool run(int x)
        {
            if (x < 0 || x % 10 == 0)
            {
                return false;
            }
            int r = 0;
            while (r < x)
            {
                r = r * 10 + x % 10;
                x = x / 10;
            }
            return r == x || r / 10 == x;
        }
    }
}

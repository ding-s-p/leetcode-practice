using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class ReverseInteger_7
    {
        public static int run(int x)
        {
            int n = 0;
            int res = 0;
            while (x != 0)
            {
                res = 10 * res + x % 10;
                if (res / 10 != n)
                {
                    return 0;
                }
                n = res;
                x = x / 10;
            };
            
            return res;
        }
    }
}

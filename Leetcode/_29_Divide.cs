using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _29_Divide
    {
        public static int run(int dividend, int divisor)
        {
            if (divisor == 0 || (dividend == int.MinValue && divisor == -1))
            {
                return int.MaxValue;
            }
            if (dividend == 0)
            {
                return 0;
            }
            int m = 1;
            if ((dividend < 0 && divisor > 0) || (divisor < 0 && dividend > 0))
            {
                m = -1;
            }
            if (dividend < 0)
            {
                dividend = -dividend;
            }
            if (divisor < 0)
            {
                divisor = -divisor;
            }
            int res = 0;
            if (divisor == 1)
            {
                return m == -1 ? -dividend : dividend;
            }
            while (true)
            {
                dividend -= divisor;
                if (dividend < 0)
                {
                    break;
                }
                else if (dividend == 0)
                {
                    res++;
                    break;
                }
                else
                {
                    res++;
                }
            }
            return m == -1 ? -res : res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class _66_PlusOne
    {
        public static int[] run(int[] digits)
        {
            //
            int add = 0;
            bool plus = true;
            for (int i = digits.Count() - 1; i > -1; i--)
            {
                if (plus)
                {
                    add = digits[i] + 1;
                    if (add > 9)
                    {
                        digits[i] = add % 10;
                    }
                    else
                    {
                        digits[i] = add;
                        return digits;
                    }
                }
            }
            if (plus)
            {
                digits = new int[digits.Count() + 1];
                digits[0] = 1;
            }
            return digits;
        }
    }
}

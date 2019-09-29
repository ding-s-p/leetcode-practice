using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class _58_LengthOfLastWord
    {
        public static int run(string s)
        {
            if (s == null)
            {
                return 0;
            }
            int l = 0;
            bool b = false;
            for (int i = s.Length - 1; i > -1; i--)
            {
                if (s[i] == ' ')
                {
                    if (b)
                    {
                        break;
                    }
                    continue;
                }
                else
                {
                    l++;
                    b = true;
                }
            }
            return l;
        }
    }
}

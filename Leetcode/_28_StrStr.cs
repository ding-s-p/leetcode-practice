using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _28_StrStr
    {
        public static int run(string haystack, string needle)
        {
            if (needle == "")
            {
                return 0;
            }
            if (haystack.Length < needle.Length)
            {
                return -1;
            }
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    if (haystack.Length - i < needle.Length)
                    {
                        break;
                    }
                    bool su = true;
                    for (int j = 1; j < needle.Length; j++)
                    {
                        if (haystack[i + j] != needle[j])
                        {
                            su = false;
                            break;
                        }
                    }
                    if (su)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}

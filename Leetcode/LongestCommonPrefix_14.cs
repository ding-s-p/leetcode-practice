using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class LongestCommonPrefix_14
    {
        public static string run(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }
            int i = 0;
            try
            {
                char a;
                while (true)
                {
                    a = strs[0][i];
                    foreach (var item in strs)
                    {
                        if (a != item[i])
                        {
                            return strs[0].Substring(0, i);
                        }
                        
                    }
                    i++;
                }
            }
            catch (Exception)
            {
            }

            return strs[0].Substring(0, i);
        }
    }
}

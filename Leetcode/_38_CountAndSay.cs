using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class _38_CountAndSay
    {

        public static string run(int n)
        {
            if (n == 1)
            {
                return "1";
            }
            string s = "1";
            StringBuilder sb = new StringBuilder();
            char cp;
            byte c;
            for (int i = 1; i < n; i++)
            {
                c = 0;
                cp = s[0];
                foreach (var item in s)
                {
                    if (cp == item)
                    {
                        c++;
                        continue;
                    }

                    sb.Append(c).Append(cp);
                    c = 1;
                    cp = item;
                }
                sb.Append(c).Append(cp);
                s = sb.ToString();
                sb.Clear();
            }
            return s;
        }

        public static string dorun(string s)
        {
            byte c = 0;
            char cp = s[0];
            StringBuilder sb = new StringBuilder();
            foreach (var item in s)
            {
                if (cp == item)
                {
                    c++;
                    continue;
                }

                sb.Append(c).Append(cp);
                c = 1;
                cp = item;
            }
            sb.Append(c).Append(cp);
            return sb.ToString();
        }
    }
}

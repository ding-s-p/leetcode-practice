using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Substring_3
    {
        public static void Main1(string[] args)
        {
            var a = LengthOfLongestSubstring("ABBA");
            Console.WriteLine("{0}", a);
            Console.ReadKey();
        }

        public static int LengthOfLongestSubstring(string s)
        {
            var hash = new Dictionary<char, int>();
            int cnt = 0;
            int res = 0;
            char ch;
            for (int i = 0, j = 0; i < s.Length; i++)
            {
                ch = s[i];

                if (hash.ContainsKey(ch))
                {
                    j = hash[ch] + 1 > j ? hash[ch] + 1 : j;
                }
                cnt = i - j + 1;
                if (res < cnt)
                {
                    res = cnt;
                }
                hash[ch] = i;
            }
            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class LetterCombinations_17
    {
        private static string[] phone = new string[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        private static int[] cnt = new int[] { 0, 0, 2, 2, 2, 2, 2, 3, 2, 3 };
        public static IList<string> run(string digits)
        {
            if (string.IsNullOrEmpty(digits))
            {
                return new string[] { };
            }

            List<string> res = new List<string>();

            int[] c = new int[digits.Length];
            int[] r = new int[digits.Length];
            int total = 1;
            for (int i = 0; i < digits.Length; i++)
            {
                r[i] = cnt[digits[i] - '0'];
                total *= r[i];
            }

            StringBuilder sb = new StringBuilder();

            for (int j = 0; j < total; j++)
            {
                for (int i = 0; i < digits.Length; i++)
                {
                    sb.Append(phone[digits[i] - '0'][c[i]]);
                }
                res.Add(sb.ToString());
                sb.Clear();
                move(c, r);
            }

            return res;
        }

        private static void move(int[] c, int[] r)
        {
            for (int i = c.Length - 1; i >= 0; i--)
            {
                if (c[i] == r[i])
                {
                    c[i] = 0;
                    continue;
                }
                c[i]++;
                break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class LongestPalindrome_5
    {
        // 动态规划-dp数组
        public static string run(string s)
        {
            if (s == null || s.Length == 0 || s.Length == 1)
            {
                return s;
            }
            bool[,] dp = new bool[s.Length, s.Length];
            int maxLength = 0;
            int maxStart = 0;
            // i -> 增量
            for (int i = 0; i < s.Length; i++)
                // j -> 字符串开始下标
                for (int j = 0; j < s.Length - i; j++)
                {
                    if (i == 0)
                    {
                        dp[j,j + i] = true;
                    }
                    else if (i == 1)
                    {
                        dp[j, j + i] = s[j] == s[j + i];
                    }
                    else if (s[j] == s[j + i])
                    {
                        dp[j, j + i] = dp[j + 1, j + i - 1];
                    }
                    else
                    {
                        dp[j, j + i] = false;
                    }
                    if (dp[j, j + i] && i > maxLength - 1)
                    {
                        maxLength = i + 1;
                        maxStart = j;
                    }
                }
            return s.Substring(maxStart, maxLength);
        }

        // 中心扩散-下标游动
        public static string run2(string s)
        {
            if (s == null || s.Length == 0 || s.Length == 1)
            {
                return s;
            }

            int l = 0, h = 0;
            int start = 0;
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                l = i;
                h = i + 1;
                while (l >= 0 && h < s.Length && s[l] == s[h])
                {
                    if (h - l > max)
                    {
                        max = h - l;
                        start = l;
                    }
                    l--;
                    h++;
                }
                l = i;
                h = i + 2;
                while (l >= 0 && h < s.Length && s[l] == s[h])
                {
                    if (h - l > max)
                    {
                        max = h - l;
                        start = l;
                    }
                    l--;
                    h++;
                }
            }
            return s.Substring(start, max + 1);
        }
    }
}

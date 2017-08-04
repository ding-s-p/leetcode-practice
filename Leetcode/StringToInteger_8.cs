using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class StringToInteger_8
    {
        private static int max = int.MaxValue / 10;
        public static int run(string arr)
        {
            if (string.IsNullOrEmpty(arr))
            {
                return 0;
            }
            int res = 0;
            int sign = 1;
            int start = 0;
            int temp = 0;
            for (; start < arr.Length; start++)
            {
                if (arr[start] == ' ')
                {
                    continue;
                }
                else if (arr[start] == '-')
                {
                    sign = -1;
                    start++;
                    break;
                }
                else if (arr[start] == '+')
                {
                    start++;
                    break;
                }
                else
                {
                    break;
                }
            }

            for (; start < arr.Length; start++)
            {
                if (arr[start] < '0' || arr[start] > '9')
                {
                    break;
                }
                temp = arr[start] - 48;
                if (res > max || (res == max && temp >= 8))
                {
                    return sign == 1 ? int.MaxValue : int.MinValue;
                }
                res = res * 10 + temp;
            }
            return sign * res;
        }
    }
}

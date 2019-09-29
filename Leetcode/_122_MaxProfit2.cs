using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class _122_MaxProfit2
    {
        public static int run(int[] prices)
        {
            int len = prices.Length;
            if (len < 2)
            {
                return 0;
            }
            int profit = 0, tem = 0;
            for (int i = 1; i < len; i++)
            {
                tem = prices[i] - prices[i - 1];
                if (tem > 0)
                {
                    profit += tem;
                }
            }
            return profit;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class _121_MaxProfit1
    {
        public static int run(int[] prices)
        {
            int i = 1;
            int profit = 0, min = 0, max = 0, tem = 0;
            for (; i < prices.Length; i++)
            {
                if (prices[i] >= prices[i - 1])
                {
                    max = i;
                    min = i - 1;
                    profit = prices[i] - prices[i - 1];
                    break;
                }
            }
            ++i;
            for (; i < prices.Length; i++)
            {
                tem = prices[i] - prices[min];
                if (tem > profit)
                {
                    //max = i;
                    profit = tem;
                }
                else if (tem < 0)
                {
                    min = i;
                }
            }
            
            return profit;
        }
    }
}

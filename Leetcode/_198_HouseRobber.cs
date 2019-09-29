using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class _198_HouseRobber
    {
        public static int run(int[] nums)
        {
            if (nums.Count() == 1)
            {
                return nums[0];
            }
            int max = nums[0], smax = 0, tem = 0;
            // 是否连续
            bool conti = true;
            for (int i = 1; i < nums.Length; i++)
            {
                if (conti)
                {
                    smax += nums[i];
                    // 和max比较，如果大就交换位置
                    if (smax > max)
                    {
                        tem = max;
                        max = smax;
                        smax = tem;
                        conti = true;
                    }
                }
                else
                {
                    max += nums[i];
                    conti = true;
                }
                

            }
            return 0;
        }
    }
}

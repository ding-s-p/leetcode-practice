using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class _53_MaxSubArray
    {
        public static int run(int[] nums)
        {
            if (nums.Count() == 1)
            {
                return nums[0];
            }
            int max = nums[0], temp = nums[0];
            for (int i = 1; i < nums.Count(); i++)
            {
                if (temp > 0)
                {
                    temp += nums[i];
                }
                else
                {
                    temp = nums[i];
                }
                max = Math.Max(max, temp);
            }
            return max;
        }
    }
}

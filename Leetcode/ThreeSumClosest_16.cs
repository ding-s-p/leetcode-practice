using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class ThreeSumClosest_16
    {
        public static int run(int[] nums, int target)
        {
            int sum;
            int closest = 0;
            int du = int.MaxValue;
            int nowDu;
            for (int i = 0; i + 2 < nums.Length; i++)
            {
                sum = nums[i] + nums[i + 1] + nums[i + 2];
                nowDu = sum > target ? sum - target : target - sum;

                if (nowDu < du)
                {
                    closest = sum;
                    du = nowDu;
                }
            }
            return closest;
        }
    }
}

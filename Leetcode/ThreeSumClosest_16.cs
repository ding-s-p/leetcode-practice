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
            Array.Sort(nums);

            int sum;
            int closest = 0;
            int du = int.MaxValue;
            int nowDu;

            for (int i = 0, j, k; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                j = i + 1;
                k = nums.Length - 1;
                while (j < k)
                {
                    sum = nums[i] + nums[j] + nums[k];
                    nowDu = Math.Abs(sum - target);
                    if (nowDu < du)
                    {
                        closest = sum;
                        du = nowDu;
                    }
                    if (sum > target)
                    {
                        k--;
                    }
                    else if(sum < target)
                    {
                        j++;
                    }
                    else
                    {
                        return sum;
                    }
                }
            }
            return closest;
        }
    }
}

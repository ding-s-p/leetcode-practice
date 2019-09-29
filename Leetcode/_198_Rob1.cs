using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class _198_Rob1
    {
        public static int run(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return nums[0];
            }
            int[] r = new int[nums.Length];
            r[0] = nums[0];
            r[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < nums.Length; i++)
            {
                r[i] = Math.Max(r[i - 2] + nums[i], r[i - 1]);
            }

            return r[nums.Length - 1];
        }

        public static int Rob(int n, int[] nums)
        {
            if (n == 0)
            {
                return nums[n];
            }
            else if (n == 1)
            {
                return Math.Max(nums[0], nums[1]);
            }
            return Math.Max(Rob(n - 2, nums) + nums[n], Rob(n - 1, nums));
        }
    }
}

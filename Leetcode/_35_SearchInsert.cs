using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _35_SearchInsert
    {
        public static int run(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            if (target <= nums[0])
            {
                return 0;
            }
            else if(target > nums[nums.Length - 1])
            {
                return nums.Length;
            }

            int s = 0, m = 0, e = nums.Length - 1;

            while (s < e - 1)
            {
                m = (s + e) / 2;
                if (nums[m] == target)
                {
                    break;
                }
                else if (nums[m] < target)
                {
                    s = m;
                }
                else
                {
                    e = m;
                }
            }
            if (nums[m] < target)
            {
                return m + 1;
            }
            else
            {
                return m;
            }

        }
    }
}

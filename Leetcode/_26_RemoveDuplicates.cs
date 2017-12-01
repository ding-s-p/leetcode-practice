using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _26_RemoveDuplicates
    {
        public static int run(int[] nums)
        {
            if (nums == null || nums.Length < 1)
            {
                return 0;
            }
            int length = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] != nums[i])
                {
                    length++;
                    nums[length] = nums[i];
                }
            }
            return length + 1;
        }
    }
}

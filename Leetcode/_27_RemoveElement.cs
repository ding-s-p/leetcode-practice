using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class _27_RemoveElement
    {
        public static int run(int[] nums, int val)
        {
            int length = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (val != nums[i])
                {
                    nums[length] = nums[i];
                    length++;
                }
            }
            return length;
        }
    }
}

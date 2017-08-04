using System;
using System.Collections.Generic;

namespace Leetcode
{
    class ThreeSum_15
    {
        public static IList<IList<int>> run(int[] nums)
        {
            Array.Sort(nums);
            int temp;
            List<IList<int>> res = new List<IList<int>>();
            
            for (int i = 0, j = 0, k = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                j = i + 1;
                k = nums.Length - 1;
                while (j < k)
                {
                    temp = nums[i] + nums[j] + nums[k];
                    if (0 == temp)
                    {
                        res.Add(new int[] { nums[i], nums[j], nums[k] });
                        j++;
                        k--;
                        while (j < k && nums[j] == nums[j - 1]) j++;
                        while (j < k && nums[k] == nums[k + 1]) k--;
                    }
                    else if (0 < temp)
                    {
                        k--;
                        //while (j < k && nums[k] == nums[k + 1]) k--;
                    }
                    else
                    {
                        j++;
                        //while (j < k && nums[j] == nums[j - 1]) j++;
                    }
                }
            }
            return res;
        }
    }
}

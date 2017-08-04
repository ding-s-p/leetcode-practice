using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class ContainerWithMostWater_11
    {
        public static int run(int[] height)
        {
            int low = 0;
            int high = height.Length - 1;
            int max = 0;
            int temp = 0;
            while (low < high)
            {
                temp = Math.Min(height[low], height[high]);
                max = Math.Max(max, (high - low) * temp);
                if (temp == height[low])
                {
                    low++;
                }
                else
                {
                    high--;
                }
            }
            return max;
        }
    }
}

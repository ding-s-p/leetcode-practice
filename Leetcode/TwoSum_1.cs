using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TwoSum_1
    {
        public static void Main1(string[] args)
        {
            var a = TwoSum2(new int[] { 3, 3 }, 6);
            Console.WriteLine("[{0},{1}]", a[0], a[1]);
            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int other = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                other = target - nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (other == nums[j])
                    {
                        return new int[2] { i, j};
                    }
                }
            }
            return null;
        }
        public static int[] TwoSum2(int[] nums, int target)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                d.Add(nums[i], i);
            }
            int other = 0;
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                other = target - nums[i];
                if (d.ContainsKey(other) && d.TryGetValue(other, out index) && index != i)
                {
                    return new int[2] { i, index };
                }
            }
            //int other = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    other = target - nums[i];
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (other == nums[j])
            //        {
            //            return new int[2] { i, j };
            //        }
            //    }
            //}
            return null;
        }
    }
}

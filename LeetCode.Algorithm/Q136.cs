using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithm
{
    /// <summary>
    /// 只出现一次的数字
    /// </summary>
    class Q136
    {
        public int SingleNumber(int[] nums)
        {
            HashSet<int> sets = new HashSet<int>();
            var result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (sets.Contains(nums[i]))
                {
                    sets.Remove(nums[i]);
                }
                else
                {
                    sets.Add(nums[i]);
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (sets.Contains(nums[i]))
                {
                    result = nums[i];
                    break;
                }
            }
            return result;
        }

        public int SingleNumber2(int[] nums)
        {
            var result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result ^= nums[i];
            }

            return result;
        }
    }
}

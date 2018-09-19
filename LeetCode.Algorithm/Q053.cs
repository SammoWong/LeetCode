using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Algorithm
{
    /// <summary>
    /// 最大子序和
    /// </summary>
    public class Q053
    {
        public int MaxSubArray(int[] nums)
        {
            var max = nums.Max();
            int result = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                result = result + nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    result += nums[j];
                    if (result > max)
                        max = result;
                }
                result = 0;
            }
            return max;
        }
    }
}

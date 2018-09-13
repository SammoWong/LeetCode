﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithm
{
    /// <summary>
    /// 移除元素
    /// </summary>
    public class Q027
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0)
                return 0;

            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if(nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }
            return i;
        }
    }
}

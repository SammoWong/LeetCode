using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithm
{
    /// <summary>
    /// 回文数：判断一个整数是否是回文数。回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。
    /// </summary>
    public class Q009
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            var value = x.ToString();
            var length = x.ToString().Length;
            var middle = length / 2;

            for (int i = 0; i < middle; i++)
            {
                if (value[i] != value[length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

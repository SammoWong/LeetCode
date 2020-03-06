using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Algorithm
{
    /// <summary>
    /// 验证回文串
    /// </summary>
    class Q125
    {
        public bool IsPalindrome(string s)
        {
            var arr = s.Where(a => char.IsLetterOrDigit(a)).Select(b => char.ToLower(b)).ToArray();
            if (arr.Length == 0)
                return true;

            var left = 0;
            var right = arr.Length - 1;
            while (left < right)
            {
                if(arr[left] != arr[right])
                {
                    return false;
                }
                left++;
                right--;
                //或者
                //if (arr[left++] != arr[right--])
                //{
                //    return false;
                //}
            }
            return true;
        }
    }
}

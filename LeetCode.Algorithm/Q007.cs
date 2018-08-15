using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithm
{
    /// <summary>
    /// 给定一个 32 位有符号整数，将整数中的数字进行反转。如果反转后的整数溢出，则返回 0。
    /// </summary>
    public class Q007
    {
        public int Reverse(int x)
        {
            var flag = x > 0;//是否正数
            var sum = flag ? x : -x;
            long result = 0;

            while (sum > 0)
            {
                var lowest = sum % 10;
                sum = sum / 10;
                result = result * 10 + lowest;
            }
            if (result > int.MaxValue)
                return 0;

            return flag ? (int)result : (int)(-result);
        }
    }
}

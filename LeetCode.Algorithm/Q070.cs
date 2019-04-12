using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithm
{
    public class Q070
    {
        //递归 斐波那契数列
        public int ClimbStairs(int n)
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            return ClimbStairs(n - 1) + ClimbStairs(n - 2);
        }

        public int ClimbStairs2(int n)
        {
            if (n == 1 || n == 2)
                return n;

            var a = 1;
            var b = 2;
            for (int i = b; i < n; i++)
            {
                var temp = a;
                a = b;
                b = temp + a;
            }
            return b;
        }
    }
}

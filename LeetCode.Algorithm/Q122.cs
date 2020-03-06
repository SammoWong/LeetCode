using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithm
{
    /// <summary>
    /// 买卖股票的最佳时机 II
    /// </summary>
    class Q122
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    maxProfit += prices[i] - prices[i - 1];
            }

            return maxProfit;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithm
{
    /// <summary>
    /// 最长公共前缀
    /// 编写一个函数来查找字符串数组中的最长公共前缀。
    /// 如果不存在公共前缀，返回空字符串""。
    /// </summary>
    public class Q014
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length <= 0)
                return string.Empty;

            var result = string.Empty;
            for (int i = 0; i < strs[0].Length; i++)
            {
                var temp = strs[0][i];
                for (int j = 0; j < strs.Length; j++)
                {
                    if(i >= strs[j].Length || temp != strs[j][i])
                    {
                        return result;
                    }
                    if(temp == strs[j][i])
                    {
                        continue;
                    }
                }
                result += temp.ToString();
            }
            return result;
        }
    }
}

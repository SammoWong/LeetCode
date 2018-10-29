using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithm
{
    /// <summary>
    /// 最后一个单词的长度
    /// 给定一个仅包含大小写字母和空格 ' ' 的字符串，返回其最后一个单词的长度。
    /// 如果不存在最后一个单词，请返回 0 。
    /// </summary>
    public class Q058
    {
        public int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            var str = s.TrimEnd();
            var index = str.Length - 1;
            var length = 0;
            while (index >= 0)
            {
                if (s[index--] == ' ')
                    break;

                length++;
            }
            return length;
        }
    }
}

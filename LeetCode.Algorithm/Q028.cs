using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithm
{
    /// <summary>
    /// 实现strStr()
    /// </summary>
    public class Q028
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
                return 0;

            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] == needle[j])
                    {
                        if (j == needle.Length - 1)
                            return i;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return -1;
        }
    }
}

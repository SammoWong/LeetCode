using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithm
{
    /// <summary>
    /// 有效的括号
    /// </summary>
    public class Q020
    {
        public bool IsValid(string s)
        {
            Stack stack = new Stack();
            var array = s.ToCharArray();
            foreach (var item in array)
            {
                if (item == '(')
                    stack.Push(')');

                else if (item == '[')
                    stack.Push(']');

                else if (item == '{')
                    stack.Push('}');

                else if (item == '<')
                    stack.Push('>');

                else if (stack.Count == 0 || stack.Pop().ToString() != item.ToString())
                    return false;
            }
            return stack.Count == 0;
        }
    }
}

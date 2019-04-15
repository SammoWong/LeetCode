using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithm
{
    public class Q083
    {
        /// <summary>
        /// 给定一个排序链表，删除所有重复的元素，使得每个元素只出现一次。
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            //多个节点情况
            ListNode current = head;
            while (current.next != null)
            {
                if(current.val == current.next.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
            return head;
        }

        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode DeleteDuplicates2(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            head.next = DeleteDuplicates2(head.next);
            if (head.val == head.next.val)
                head = head.next;
            return head;
        }
    }

    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int x) { val = x; }
    }
}

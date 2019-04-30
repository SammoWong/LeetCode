using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithm
{
    public class Q100
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            if (p != null && q != null && p.val == q.val)
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            else
                return false;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}

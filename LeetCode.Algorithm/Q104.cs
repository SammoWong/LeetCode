using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithm
{
    public class Q104
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            var left = MaxDepth(root.left);
            var right = MaxDepth(root.right);
            return left > right ? left + 1 : right + 1;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }
}

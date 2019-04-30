using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithm
{
    /// <summary>
    /// 对称二叉树
    /// 给定一个二叉树，检查它是否是镜像对称的
    /// </summary>
    public class Q101
    {
        public bool IsSymmetric(TreeNode root)
        {
            return Judge(root, root);
        }

        public bool Judge(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
                return true;
            if (left == null || right == null)
                return false;
            if (left.val != right.val)
                return false;
            return Judge(left.left, right.right) && Judge(left.right, right.left);
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

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

    public class Solution
    {
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (subRoot == null) return true;
            if (root == null) return false;

            if (isTheSameTree(root,subRoot))
            {
                return true;
            }

            return IsSubtree(root.left,subRoot)|| IsSubtree(root.right, subRoot);
        }
        public bool isTheSameTree(TreeNode first, TreeNode second)
        {
            if (first == null && second == null)
                return true;
            if(first!=null&&second!=null &&first.val==second.val)
            {
                return ((isTheSameTree(first.left, second.left) && isTheSameTree(first.right, second.right)));
            }
            return false;
        }
    }
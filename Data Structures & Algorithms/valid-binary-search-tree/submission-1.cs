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
        bool validate(TreeNode node,int right,int left)
        {
            if (node == null) return true;
            if (!(node.val < right && node.val > left)) return false;
            return (validate(node.left, node.val, left) && validate(node.right, right, node.val));
        }

        public bool IsValidBST(TreeNode root)
        {
            return validate(root, int.MaxValue, int.MinValue);
        }
    }

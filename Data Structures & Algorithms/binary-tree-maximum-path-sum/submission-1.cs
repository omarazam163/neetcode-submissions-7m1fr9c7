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
        int res;
        int getMax(TreeNode root)
        {
            if (root == null) return 0;

            int left = getMax(root.left);
            int right = getMax(root.right);
            left = Math.Max(left,0);
            right = Math.Max(right,0);

            res = Math.Max(res, left+right+root.val);

            return root.val + Math.Max(left,right);
        }
        public int MaxPathSum(TreeNode root)
        {
            this.res = root.val;
            getMax(root);
            return res;
        }
    }

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
        bool balanced = true;
        int solve(TreeNode current)
        {
            if (current == null)
            {
                return 0;
            }
            int left = solve(current.left);
            int right = solve(current.right);
            if (Math.Abs(left - right) > 1)
            {
                balanced = false;
                return 0;
            }

            return 1 + Math.Max(left,right);
        }
        public bool IsBalanced(TreeNode root)
        {
            solve(root);
            return balanced;
        }
    }

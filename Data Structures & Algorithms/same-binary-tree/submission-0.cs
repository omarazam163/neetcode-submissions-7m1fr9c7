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
        bool equal=true;
        void dfs(TreeNode first, TreeNode second)
        {
            if (first == null&& second==null)
            {
                return;
            }
            if((first==null&&second!=null)||(second==null&&first!=null))
            {
                equal = false;
                return;
            }

            if (first.val != second.val) { equal = false; return; }
            dfs(first.left,second.left);
            dfs(first.right, second.right);
        }
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            dfs(p,q);
            return equal;
        }
    }
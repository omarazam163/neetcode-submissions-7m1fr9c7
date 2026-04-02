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
        List<int> res = new();
        int len = 0;
        void inorderTraverse(TreeNode node)
        {
            if (node == null) return;
            if (res.Count == len) return;
            inorderTraverse(node.left);
            res.Add(node.val);
            inorderTraverse(node.right);
        }
        public int KthSmallest(TreeNode root, int k)
        {
            len = k;
            inorderTraverse(root);
            return res[k - 1];
        }
    }

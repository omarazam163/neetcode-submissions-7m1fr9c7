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
        public TreeNode InvertTree(TreeNode root)
        {
            if(root==null) return null;
            Stack<TreeNode> stack = new();
            stack.Push(root);
            while(stack.Count>0)
            {
                //pop
                TreeNode Current = stack.Pop();

                // push children
                if (Current.right != null) stack.Push(Current.right);
                if (Current.left != null) stack.Push(Current.left);
                //process
                TreeNode temp = Current.left;
                Current.left = Current.right;
                Current.right = temp;
            }
            return root;
        }
    }
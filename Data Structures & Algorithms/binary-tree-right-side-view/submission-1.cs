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
        public List<int> RightSideView(TreeNode root)
        {
            List<int> res = new();
            if (root == null) return res;
            Queue<TreeNode> que = new();
            que.Enqueue(root);
            while(que.Count>0)
            {
                Stack<int> stack = new();
                for(int i=que.Count;i>0;i--)
                {
                    TreeNode current = que.Dequeue();
                    if (current.left != null) que.Enqueue(current.left);
                    if (current.right != null) que.Enqueue(current.right);
                    if(i==1)
                    {
                        res.Add(current.val);
                    }
                }
            }
            return res;
        }    }

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
        bool AddToStack(Stack<KeyValuePair<TreeNode, int>> stack,TreeNode node,int MaxValue)
        {
            if (node != null)
            {
                if (node.val >= MaxValue)
                {
                    stack.Push(new KeyValuePair<TreeNode, int>(node, node.val));
                    return true;
                }
                else
                {
                    stack.Push(new KeyValuePair<TreeNode, int>(node, MaxValue));
                    return false;
                }
            }
            else return false;
        }
        public int GoodNodes(TreeNode root)
        {
            int res = 0;
            if (root == null) return res;
            res = 1;
            Stack<KeyValuePair<TreeNode,int>> stack = new();
            stack.Push(new KeyValuePair<TreeNode, int>(root,root.val));
            while(stack.Count>0)
            {
                KeyValuePair<TreeNode, int> curr = stack.Pop();
                TreeNode cuurentNode = curr.Key;
                int MaxValueInThePath = curr.Value;
                if (AddToStack(stack, cuurentNode.right, MaxValueInThePath)) res++;
                if (AddToStack(stack, cuurentNode.left, MaxValueInThePath)) res++;
            }
            return res;
        }

    }

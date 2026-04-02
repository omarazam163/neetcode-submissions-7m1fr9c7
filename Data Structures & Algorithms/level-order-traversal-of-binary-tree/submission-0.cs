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
        public List<List<int>> LevelOrder(TreeNode root)
        {
            List<List<int>> res = new();
            if (root == null) return res;
            Queue<TreeNode> que = new();
            que.Enqueue(root);
            while(que.Count>0)
            {
                List<TreeNode> currentLevelNodes = new();
                while (que.Count>0)
                {
                    currentLevelNodes.Add(que.Dequeue());
                }
                List<int> currentLevelVal = new();
                foreach (var x in currentLevelNodes)
                {
                    if (x.left != null) que.Enqueue(x.left);
                    if (x.right != null) que.Enqueue(x.right);
                    currentLevelVal.Add(x.val);
                }
                res.Add(currentLevelVal);
            }
            return res;
        }
    }

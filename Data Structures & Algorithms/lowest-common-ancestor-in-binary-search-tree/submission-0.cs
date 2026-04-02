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
        List<TreeNode> getPathofTheNode(TreeNode root,TreeNode target)
        {
            TreeNode current = root;
            List<TreeNode> path = new();
            while (current.val != target.val)
            {
                path.Add(current);
                if(current.val>target.val)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }
            }
            path.Add(current);
            return path;
        }
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            List<TreeNode> path1 = getPathofTheNode(root,p);
            List<TreeNode> path2 = getPathofTheNode(root, q);
            TreeNode res= new();
            bool flag = false;
            for(int i=path1.Count-1;i>=0;i--)
            {
                for(int j = path2.Count - 1; j >= 0; j--)
                {
                    if (path1[i].val == path2[j].val)
                    {
                        res = path1[i];
                        flag = true;
                        break;
                    }
                    if (flag) break;
                }
            }
            return res;
        }
    }
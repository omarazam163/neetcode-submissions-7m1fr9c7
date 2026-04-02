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

    public class Codec
    {
        StringBuilder sb = new();
        void Bfs(TreeNode root)
        {
            if (root == null) return;
            Queue<TreeNode> que = new();
            que.Enqueue(root);
            while (que.Count > 0)
            {
                int i = que.Count;
                while (i > 0)
                {
                    TreeNode current = que.Dequeue();
                    if (current != null)
                    {
                        sb.Append(current.val.ToString() + ",");
                        que.Enqueue(current.left);
                        que.Enqueue(current.right);
                    }
                    else
                    {
                        sb.Append("#,");
                    }
                    i--;
                }
            }
        }

        // Encodes a tree to a single string.
        public string Serialize(TreeNode root)
        {
            Bfs(root);
            if (sb.Length > 0) sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        // Decodes your encoded data to tree.
        public TreeNode Deserialize(string data)
        {
            if (data.Length == 0) return null;
            int[] Bfs = data.Split(",").Select((x) => (x == "#") ? int.MinValue : int.Parse(x)).ToArray();
            Queue<TreeNode> que = new();
            int i = 1;
            TreeNode root = new TreeNode(Bfs[0]);
            que.Enqueue(root);
            while(que.Count>0)
            {
                TreeNode current = que.Dequeue();

                if (Bfs[i] != int.MinValue)
                {

                    current.left = new(Bfs[i]);
                    que.Enqueue(current.left);
                }
                i++;
                if(Bfs[i] != int.MinValue)
                {
                    current.right = new(Bfs[i]);
                    que.Enqueue(current.right);
                }
                i++;
            }
            return root;
        }
    }

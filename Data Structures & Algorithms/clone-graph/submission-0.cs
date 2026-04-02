/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

    public class Solution
    {
        Dictionary<Node, Node> cloned = new();
        Node clone(Node node)
        {
            if (cloned.ContainsKey(node)) return cloned[node];
            Node copy = new Node(node.val);
            cloned.Add(node,copy);
            foreach (Node nei in node.neighbors)
            {
                copy.neighbors.Add(clone(nei));
            }
            return copy;
        }
        public Node CloneGraph(Node node)
        {
            if (node == null) return null;
            return clone(node);
        }
    }

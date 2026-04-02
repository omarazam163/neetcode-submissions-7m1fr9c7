/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
         if(head==null) return null;
            Node current = head;
            Dictionary < Node,Node > created= new();
            Node newHead = new Node(head.val);
            Node newCurrent = newHead;
            created[head] = newHead;
            while(current!=null)
            {
                newCurrent.val = current.val;
                if (current.next != null)
                {
                    if (created.ContainsKey(current.next))
                    {
                        newCurrent.next = created[current.next];
                    }
                    else
                    {
                        newCurrent.next = new Node(current.next.val);
                        created[current.next] = newCurrent.next;
                    }
                }
                else
                {
                    newCurrent.next = null;
                }
                if(current.random != null){
                    if (created.ContainsKey(current.random))
                    {
                        newCurrent.random = created[current.random];
                    }
                    else
                    {
                        newCurrent.random = new Node(current.random.val);
                        created[current.random] = newCurrent.random;
                    }
                }
                else
                {
                    newCurrent.random = null;
                }

                current = current.next;
                newCurrent = newCurrent.next;
            }
            return newHead;
    }
}

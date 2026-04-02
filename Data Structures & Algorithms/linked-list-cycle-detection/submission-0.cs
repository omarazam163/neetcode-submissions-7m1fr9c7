/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            if(head==null) return false;
            HashSet<ListNode> visted = new();
            ListNode current = head;
            while(current.next!=null)
            {
                if (visted.Contains(current.next)) return true;
                visted.Add(current);
                current = current.next;
            }
            return false;
        }
    }
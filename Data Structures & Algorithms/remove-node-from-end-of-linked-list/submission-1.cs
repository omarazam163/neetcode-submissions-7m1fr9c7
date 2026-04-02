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
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode s = head;
            ListNode f = head;
            for(int i=1;i<n;i++)
            {
                f = f.next;
            }
            ListNode prev = null;
            while(f.next!=null)
            {
                prev = s;
                s = s.next;
                f = f.next;
            }
            if(prev!=null)prev.next = s.next;
            else head = head.next;
            return head;
        }
    }

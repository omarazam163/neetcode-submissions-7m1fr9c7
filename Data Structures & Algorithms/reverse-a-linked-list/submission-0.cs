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
        public ListNode ReverseList(ListNode head)
        {
            if(head==null) return head;
            ListNode current = head;
            ListNode next = head?.next;
            ListNode before = null;
            while (next != null)
            {
                Console.WriteLine($"{current.val} {next.val} {before?.val}");
                current.next = before;
                before = current;
                current = next;
                next = next.next;
            }
            current.next = before;
            return current;
        }
    }
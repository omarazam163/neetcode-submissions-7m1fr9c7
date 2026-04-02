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
        public void ReorderList(ListNode head)
        {
            ListNode s= head;
            ListNode f = head.next;
            while(f!=null&& f.next!=null)
            {
                s = s.next;
                f = f.next.next;
            }

            //reverse second portion of the linked list
            ListNode Second = s.next;
            s.next = null;
            ListNode prev = null;
            while(Second!=null)
            {
                ListNode temp = Second.next;
                Second.next = prev;
                prev = Second;
                Second = temp;
            }

            ListNode first = head;
            ListNode second = prev;
            while(second!=null)
            {
                ListNode temp1 = first.next;
                ListNode temp2 = second.next;
                first.next = second;
                second.next = temp1;
                first = temp1;
                second = temp2;
            }
        }
    }

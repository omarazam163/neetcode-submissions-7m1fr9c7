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
            Stack<ListNode> stack = new();
            ListNode current = head;
            while(current!=null)
            {
                stack.Push(current);
                current = current.next;
            }
            current = head;
            while(current.next != stack.Peek() && current != stack.Peek())
            {
                ListNode temp = current.next;
                current.next = stack.Pop();
                current.next.next = temp;
                current = temp;
            }
            if(current != stack.Peek()) 
            {
                current.next = stack.Pop();
                current.next.next =null;
            }
            else
            {
                current.next = null;
            }
        }
    }

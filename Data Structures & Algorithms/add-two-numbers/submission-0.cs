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
        int getNumber(ListNode head)
        {
            int n = 0;
            int number = 0;
            ListNode curr = head;
            while (curr != null)
            {
                number += curr.val * (int)(Math.Pow(10, n));
                n++;
                curr = curr.next;
            }
            return number;
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int num1 = getNumber(l1);
            int num2 = getNumber(l2);
            string res = (num1 + num2).ToString();
            ListNode head = new ListNode();
            ListNode curr = head;
            for (int i = res.Length - 1; i >= 0; i--)
            {
                curr.val = res[i] - '0';
                if (i != 0)
                {
                    curr.next = new ListNode();
                    curr = curr.next;
                }
                else curr.next = null;
            }
            return head;
        }
    }

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
        ListNode ReverseLinkedList(ListNode head)
        {
            ListNode current = head;
            ListNode prev = null;
            while (current != null)
            {
                ListNode temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            return prev;
        }
        void MergeTwoLIsts(ListNode list1, ListNode list2)
        {
            ListNode current = list1;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = list2;
        }
        bool flag = false;
        ListNode partition(ListNode head,int k)
        {
            ListNode endOfFirstPart = head;
            for (int i = 0; i < k - 1; i++)
            {
                if (endOfFirstPart.next == null) {
                    flag = true;
                    break;
                };
                endOfFirstPart = endOfFirstPart.next;
            }
            ListNode StartOfSecondPart = endOfFirstPart.next;
            endOfFirstPart.next = null;
            return StartOfSecondPart;
        }
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode current = head;
            List<ListNode> headsOfEveryPartion = new();
            ListNode startOfNextPartion = head;
            int count = 1;
            while(startOfNextPartion!=null)
            {
                headsOfEveryPartion.Add(startOfNextPartion);
                startOfNextPartion = partition(startOfNextPartion, k);
            }
            ListNode headOfRes = ReverseLinkedList(headsOfEveryPartion[0]);
            for(int i=1;i<headsOfEveryPartion.Count;i++)
            {
                ListNode afterReverse;
                if (i==headsOfEveryPartion.Count-1&&flag)
                {
                    afterReverse = headsOfEveryPartion[i];
                }
                else
                {
                    afterReverse = ReverseLinkedList(headsOfEveryPartion[i]);
                }
                MergeTwoLIsts(headOfRes, afterReverse);
            }
            return headOfRes;
        }
    }
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
        bool Allnulls(ListNode[] currentPointers)
        {
            foreach(var x in currentPointers)
            {
                if (x != null) return false;
            }
            return true;
        }
        void updatePointer(ListNode[] currentPointers,int index)
        {
            if (currentPointers[index] != null) currentPointers[index] = currentPointers[index].next;
        }
        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode dummy = new ListNode();
            ListNode[] currentPointers = new ListNode[lists.Length];
            ListNode current = dummy; 
            for(int i=0;i<currentPointers.Length;i++)
            {
                currentPointers[i] = lists[i];
            }
            while(!Allnulls(currentPointers))
            {
                int Min =int.MaxValue;
                ListNode minNode = null;
                int i = -1;
                int minIndex = 0;
                foreach(var x in currentPointers)
                {
                    i++;
                    if (x == null) continue;
                    if(x.val<Min)
                    {
                        Min = x.val;
                        minNode = x;
                        minIndex = i;
                    }
                }
                current.next = minNode;
                updatePointer(currentPointers, minIndex);
                current = current.next;
            }

            return dummy.next;
        }
    }
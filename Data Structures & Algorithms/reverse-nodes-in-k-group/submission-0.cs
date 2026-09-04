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

public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        if (head == null || k == 1)
            return head;

        ListNode dummy = new ListNode(0);
        dummy.next = head;

        ListNode groupPrev = dummy;

        while (true)
        {
            // 1. Find the kth node
            ListNode kth = groupPrev;

            for (int i = 0; i < k; i++)
            {
                kth = kth.next;

                if (kth == null)
                    return dummy.next;
            }

            // 2. Save the node after the group
            ListNode groupNext = kth.next;

            // 3. Reverse the group
            ListNode prev = groupNext;
            ListNode current = groupPrev.next;

            while (current != groupNext)
            {
                ListNode next = current.next;

                current.next = prev;

                prev = current;
                current = next;
            }

            // 4. Connect previous group to reversed group
            ListNode temp = groupPrev.next;
            groupPrev.next = kth;

            // 5. Move groupPrev to the end of reversed group
            groupPrev = temp;
        }

        return dummy.next;
    }

    
}

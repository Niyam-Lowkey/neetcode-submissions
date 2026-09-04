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
    public void ReorderList(ListNode head) {

        if (head == null || head.next == null)
                return;

        ListNode fast = head;
        ListNode slow = head;

        while(fast != null && fast.next != null){
            fast = fast.next.next;
            slow = slow.next;
        }
        
        ListNode second = slow.next;
        slow.next = null;

        ListNode current = second;
        ListNode prev = null;

        while(current != null){
            ListNode next = current.next;
            current.next = prev;

            prev = current;
            current = next;
        }

        second = prev;

        ListNode first = head;

        while(second != null){
            ListNode firstnext = first.next;
            ListNode secondnext = second.next;

            first.next = second;
            second.next = firstnext;

            first = firstnext;
            second = secondnext;
        }        


    }
}

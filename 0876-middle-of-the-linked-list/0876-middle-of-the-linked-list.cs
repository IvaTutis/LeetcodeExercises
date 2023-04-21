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
    public ListNode MiddleNode(ListNode head) {
        ListNode middle = head;
        ListNode index = head;
        
        while (index != null && index.next != null) {
            middle = middle.next;
            index = index.next.next;
        }
        
        return middle;
    }
}
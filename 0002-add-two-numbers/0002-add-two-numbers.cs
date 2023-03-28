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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var sum = l1.val+l2.val;
        var overflow = (int)sum/10;
        var lastDigitFlipped = new ListNode(sum%10, null);
        while (l1.next!=null || l2.next!=null || overflow!=0){
            sum=overflow;
            if(l1.next!=null) {
                l1 = l1.next;
                sum=sum+l1.val;
                }
             if(l2.next!=null) {
                l2 = l2.next;
                sum=sum+l2.val;
                }
            overflow = (int)sum/10;
            var currentDigitFlipped = new ListNode(sum%10, lastDigitFlipped);
            lastDigitFlipped=currentDigitFlipped;
        }
        
        //flip list back to old format
        var lastDigit = new ListNode(lastDigitFlipped.val, null);
        while(lastDigitFlipped.next!=null){
            lastDigitFlipped=lastDigitFlipped.next;
            var currentDigit=new ListNode(lastDigitFlipped.val, lastDigit);
            lastDigit=currentDigit;
        }
        
        return lastDigit;
    }
}
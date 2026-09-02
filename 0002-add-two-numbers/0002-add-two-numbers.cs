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
        ListNode l3 = new ListNode(0);
        ListNode cl3 = l3;
        ListNode cl1 = l1;
        ListNode cl2 = l2;
        int sum =0;
        while(cl1 != null || cl2 != null)
        { 
            int val1 = (cl1 != null)? cl1.val : 0;
            int val2 = (cl2 != null)? cl2.val : 0;

            int value = val1 + val2 + sum;
            int digit = value%10;
            sum = value/10;
            cl3.next = new ListNode(digit);
            cl3 = cl3.next;
            if (cl1 != null)
                cl1 = cl1.next;

            if (cl2 != null)
                cl2 = cl2.next;
             
        }
        if (sum > 0)
        {
            cl3.next = new ListNode(sum);
        }
        return l3.next;
    }
}
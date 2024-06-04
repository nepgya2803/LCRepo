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
        ListNode current = new ListNode();
        ListNode firstNode = new ListNode();
        firstNode = current;
        int carrier = 0;
        while(l1 != null || l2 != null || carrier != 0)
        {   
            int sum = 0;
            int v1 = l1 != null ? l1.val : 0;
            int v2 = l2 != null ? l2.val : 0;
            sum += (v1 + v2 + carrier);
            carrier = sum / 10;
            int nextValue = sum % 10;
            current.next  = new ListNode(nextValue);
            current = current.next;
            l1 = l1?.next;
            l2 = l2?.next;
    
        }  
        return firstNode.next;
    }
}

   
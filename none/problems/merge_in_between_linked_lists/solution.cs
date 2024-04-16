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
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
    {
        ListNode result = new ListNode();
        ListNode head = new ListNode();
        int i = 0;
        result = list1;
        head = result;
        while (list1 != null)
        {
            if (i > 0 && i < a || i > b)
            {
                result.next = list1;
                result = result.next;
            }
            else if (i >= a && i <= b)
            {
                while (list2 != null)
                {
                    result.next = list2;
                    result = result.next;
                    list2 = list2.next;
                }
            }
            list1 = list1.next;
            i++;
        }

        return head;
    }
}
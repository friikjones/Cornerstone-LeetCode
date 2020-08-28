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
    public ListNode RotateRight(ListNode head, int k) {
        if (head == null || head.next == null)
            return head;
        
        ListNode n1 = head,
                 n2 = head,
                 n3 = null;
        int i = 1;
        
        while (n1.next != null)
        {
            n1 = n1.next;
            i++;
        }
        
        if (k > i)
            k %= i;
        
        if (k == i || k == 0)
            return head;
        
        i -= k;
        
        while (i > 0)
        {
            n3 = n2;
            n2 = n2.next;
            
            i--;
        }
        
        n3.next = null;
        n1.next = head;
        
        return n2;
    }
}
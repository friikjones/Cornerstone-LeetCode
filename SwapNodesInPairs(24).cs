public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if(head == null || head.next == null)
            return head;
            
        ListNode dummyNode = new ListNode(-1);
        dummyNode.next = head;
        ListNode node1 = dummyNode, node2 = node1.next, node3 = node2.next, node4 = node3.next;
        
        while(node3 != null)
        {
            node1.next = node3;
            node2.next = node4;
            node3.next = node2;
            
            node1 = node2;
            if (node1 != null)
                node2 = node1.next;
            if (node2 != null && node2.next != null)
                node3 = node2.next;
            else
                node3 = null;
            if (node3 != null)
                node4 = node3.next;
        }
        
        return dummyNode.next;
    }
}
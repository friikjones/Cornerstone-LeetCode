public class Solution {
		public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

			// Build the ListNode with the sum of two ListNodes
			return addNodeList(l1, l2);
		}

		// Sums the values in two ListNodes and returns it in a ListNode
		public ListNode addNodeList(ListNode node1, ListNode node2, int carry = 0){

			int node1Val = 0;
			int node2Val = 0;
			ListNode nextNode1 = null;
			ListNode nextNode2 = null;
			int sum = 0;

			// Base case
			if(node1 == null && node2 == null && carry == 0){
				return null;
			}

			// To avoid accessing attributes for a null node
			if(node1 != null){
				node1Val = node1.val;
				nextNode1 = node1.next;
			}

			if(node2 != null){
				node2Val = node2.val;
				nextNode2 = node2.next;
			}

			// Add the current node values and any carry from previous node addition
			sum = node1Val + node2Val + carry;
			
			// sum/10 is the carry and sum%10 gets placed into the node
			return new ListNode(sum % 10, addNodeList(nextNode1, nextNode2, sum/10));
		}   
	}
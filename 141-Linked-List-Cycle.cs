// public class ListNode {
//     public int val;
//     public ListNode next;
//     public ListNode(int val = 0, ListNode next = null) {
//         this.val = val;
//         this.next = next;
//     }
// }

public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode slow_pointer = head, fast_pointer = head;
        while (fast_pointer != null && fast_pointer.next != null) {
            slow_pointer = slow_pointer.next;
            fast_pointer = fast_pointer.next.next;
            if (slow_pointer == fast_pointer) {
                return true;
            }
        }
        return false;
    }
}
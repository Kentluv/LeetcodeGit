public class SwapPairs_Solution {
    public ListNode SwapPairs(ListNode head) {
        var result = new ListNode(0);
        var current = result;
        if(head != null) {
            current.next = head;
        }
        while (head != null && head.next != null) {
            var next = head.next;
            head.next = next.next;
            next.next = head;
            current.next = next;
            current = head;
            head = head.next;
        }
        return result.next;
    }
}
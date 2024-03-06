public class ReverseBetween_Solution {
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if(left == right)
            return head;
        var dummy = new ListNode(0);
        dummy.next = head;
        var pre = dummy;
        for(var i = 0; i < left - 1; i++)
            pre = pre.next;
        var start = pre.next;
        var then = start.next;
        for(var i = 0; i < right - left; i++) {
            start.next = then.next;
            then.next = pre.next;
            pre.next = then;
            then = start.next;
        }
        return dummy.next;
    }
}
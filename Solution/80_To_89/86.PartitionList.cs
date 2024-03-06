public class Partition_Solution {
    public ListNode Partition(ListNode head, int x) {
        var dummy = new ListNode(0);
        dummy.next = head;
        var current = dummy;
        ListNode insert = null!;
        while (current.next != null) {
            if (current.next.val < x) {
                if (insert != null && insert != current) {
                    var temp = insert.next;
                    insert.next = current.next;
                    current.next = current.next.next;
                    insert.next.next = temp;
                    insert = insert.next;
                } else {
                    current = current.next;
                }
            } else {
                if (insert == null) {
                    insert = current;
                }
                current = current.next;
            }
        }
        return dummy.next;
    }
}
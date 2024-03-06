public class DeleteDuplicates_Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        var dummy = new ListNode(0);
        dummy.next = head;
        var current = dummy;
        while (current.next != null && current.next.next != null)
        {
            if (current.next.val == current.next.next.val)
            {
                var val = current.next.val;
                while (current.next != null && current.next.val == val)
                {
                    current.next = current.next.next;
                }
            }
            else
            {
                current = current.next;
            }
        }
        return dummy.next;
    }
}
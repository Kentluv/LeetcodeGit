
public class RotateRight_Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if(head == null || head.next == null || k == 0) return head!;
        var length = 1;
        var tail = head;
        while(tail.next != null)
        {
            length++;
            tail = tail.next;
        }
        k = k % length;
        if(k == 0) return head!;
        var newHead = head;
        for (int i = 0; i < length - k; i++)
        {
            newHead = newHead.next;
        }
        tail.next = head;
        for (int i = 0; i < length - k - 1; i++)
        {
            head = head.next;
        }
        newHead = head.next;
        head.next = null!;
        return newHead;
    }
}
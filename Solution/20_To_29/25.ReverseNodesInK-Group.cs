
public class ReverseKGroup_Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        var result = new ListNode(0);
        var current = result;

        while (head != null) {
            var count = 0;
            var temp = head;
            while (temp != null && count < k) {
                temp = temp.next;
                count++;
            }

            if (count == k) {
                var reversed = Reverse(head, k);
                current.next = reversed!;
                while (current.next != null) {
                    current = current.next;
                }
            } else {
                current.next = head;
                break;
            }

            head = temp!;
        }
        return result.next;
    }

    private ListNode? Reverse(ListNode head, int k)
    {
        ListNode? prev = null;
        ListNode? current = head;
        ListNode? next = null;

        while (current != null && k > 0)
        {
            next = current.next;
            current.next = prev!;
            prev = current;
            current = next;
            k--;
        }

        return prev;
    }
}
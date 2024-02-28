public class MergeKLists_Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        var lst = new List<int>();
        foreach (var list in lists) {
            var current = list;
            while (current != null) {
                lst.Add(current.val);
                current = current.next;
            }
        }

        lst.Sort();

        var result = new ListNode(0);
        foreach (var item in lst) {
            var current = result;
            while (current.next != null) {
                current = current.next;
            }
            current.next = new ListNode(item);
        }
        return result.next;
    }
}
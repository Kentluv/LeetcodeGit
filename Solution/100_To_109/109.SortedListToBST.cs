
public class SortedListToBST_Solution {
    public TreeNode SortedListToBST(ListNode head) {
        var list = new List<int>();
        while(head != null) {
            list.Add(head.val);
            head = head.next;
        }
        return BuildTree(list, 0, list.Count - 1);
    }

    private TreeNode BuildTree(List<int> list, int v1, int v2)
    {
        if(v1 > v2)
            return null!;
        var mid = v1 + (v2 - v1) / 2;
        var root = new TreeNode(list[mid]);
        root.left = BuildTree(list, v1, mid - 1);
        root.right = BuildTree(list, mid + 1, v2);
        return root;
    }
}
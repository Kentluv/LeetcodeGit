
public class RecoverTree_Solution {
    public void RecoverTree(TreeNode root) {
        var stack = new Stack<TreeNode>();
        TreeNode x = null!, y = null!, pred = null!;
        while(stack.Count > 0 || root != null) {
            while(root != null) {
                stack.Push(root);
                root = root.left;
            }
            root = stack.Pop();
            if(pred != null && root.val < pred.val) {
                y = root;
                if(x == null) x = pred;
                else break;
            }
            pred = root;
            root = root.right;
        }
        Swap(x, y);
    }

    private void Swap(TreeNode? x, TreeNode? y)
    {
        var temp = x!.val;
        x.val = y!.val;
        y.val = temp;
    }
}
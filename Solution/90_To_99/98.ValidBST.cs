public class IsValidBST_Solution {
    public bool IsValidBST(TreeNode root) {
        var stack = new Stack<TreeNode>();
        TreeNode? pre = null;
        while(root != null || stack.Count > 0) {
            while(root != null) {
                stack.Push(root);
                root = root.left;
            }
            root = stack.Pop();
            if(pre != null && root.val <= pre.val)
                return false;
            pre = root;
            root = root.right;
        }
        return true;
    }
}
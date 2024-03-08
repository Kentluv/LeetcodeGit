public class Flatten_Solution {
    public void Flatten(TreeNode root) {
        if(root == null)
            return;
        var left = root.left;
        var right = root.right;
        Flatten(left);
        Flatten(right);
        root.left = null!;
        root.right = left;
        var current = root;
        while(current.right != null) {
            current = current.right;
        }
        current.right = right;
    }
}
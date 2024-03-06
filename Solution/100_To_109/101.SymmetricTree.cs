

public class IsSymmetric_Solution {
    public bool IsSymmetric(TreeNode root) {
        var left = root.left;
        var right = root.right;
        return IsSymmetric(left, right);
    }

    private bool IsSymmetric(TreeNode left, TreeNode right)
    {
        if(left == null && right == null)
            return true;
        if(left == null || right == null)
            return false;
        if(left.val != right.val)
            return false;
        return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
    }
}
public class HasPathSum_Solution {
    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root == null)
            return false;
        var left = root.left;
        var right = root.right;
        if(left == null && right == null)
            return root.val == targetSum;

        return HasPathSum(left!, targetSum - root.val) || HasPathSum(right, targetSum - root.val);
    }
}
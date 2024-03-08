
public class IsBalanced_Solution {
    public bool IsBalanced(TreeNode root) {
        var result = true;
        Depth(root, ref result);
        return result;
    }

    private void Depth(TreeNode root, ref bool result)
    {
        if(root == null)
            return;
        var left = GetDepth(root.left);
        var right = GetDepth(root.right);
        if(Math.Abs(left - right) > 1)
            result = false;
        Depth(root.left, ref result);
        Depth(root.right, ref result);
    }

    private int GetDepth(TreeNode node)
    {
        if(node == null)
            return 0;
        return 1 + Math.Max(GetDepth(node.left), GetDepth(node.right));
    }
}
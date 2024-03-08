
public class MinDepth_Solution {
    public int MinDepth(TreeNode root) {
        if(root == null)
            return 0;
        var current = new List<TreeNode>{root};
        var next = new List<TreeNode>();
        var depth = 1;

        while(current.Count > 0) {
            foreach(var node in current) {
                if(node.left == null && node.right == null)
                    return depth;
                if(node.left != null)
                    next.Add(node.left);
                if(node.right != null)
                    next.Add(node.right);
            }
            current = next;
            next = new List<TreeNode>();
            depth++;
        }
        return depth;
    }
}
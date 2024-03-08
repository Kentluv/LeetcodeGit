public class MaxDepth_Solution {
    public int MaxDepth(TreeNode root) {
        var result = 0;
        if(root == null)
            return result;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count > 0) {
            var count = queue.Count;
            for(var i = 0; i < count; i++) {
                var current = queue.Dequeue();
                if(current.left != null)
                    queue.Enqueue(current.left);
                if(current.right != null)
                    queue.Enqueue(current.right);
            }
            result++;
        }
        return result;
    }
}
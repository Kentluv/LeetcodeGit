public class LevelOrder_Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var result = new List<IList<int>>();
        if(root == null)
            return result;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count > 0) {
            var level = new List<int>();
            var count = queue.Count;
            for(var i = 0; i < count; i++) {
                var current = queue.Dequeue();
                level.Add(current.val);
                if(current.left != null)
                    queue.Enqueue(current.left);
                if(current.right != null)
                    queue.Enqueue(current.right);
            }
            result.Add(level);
        }
        return result;
    }
}
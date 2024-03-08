public class LevelOrderBottom_Solution {
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        var results = new List<IList<int>>();
        if(root == null)
            return results;
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
            results.Insert(0, level);
        }
        return results;
    }
}
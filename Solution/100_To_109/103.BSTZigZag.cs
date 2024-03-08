public class ZigzagLevelOrder_Solution {
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        var results = new List<IList<int>>();
        if(root == null)
            return results;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var isLeftToRight = true;
        while(queue.Count > 0) {
            var level = new List<int>();
            var count = queue.Count;
            for(var i = 0; i < count; i++) {
                var current = queue.Dequeue();
                if(isLeftToRight)
                    level.Add(current.val);
                else
                    level.Insert(0, current.val);
                if(current.left != null)
                    queue.Enqueue(current.left);
                if(current.right != null)
                    queue.Enqueue(current.right);
            }
            results.Add(level);
            isLeftToRight = !isLeftToRight;
        }
        return results;
    }
}
public class PathSumII_Solution {
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        var results = new List<IList<int>>();
        if(root == null)
            return results;
        var left = root.left;
        var right = root.right;
        if(left == null && right == null) {
            if(root.val == targetSum) {
                results.Add(new List<int> { root.val });
            }
            return results;
        }
        var leftResults = PathSum(left!, targetSum - root.val);
        var rightResults = PathSum(right, targetSum - root.val);
        foreach(var leftResult in leftResults) {
            leftResult.Insert(0, root.val);
            results.Add(leftResult);
        }
        foreach(var rightResult in rightResults) {
            rightResult.Insert(0, root.val);
            results.Add(rightResult);
        }
        return results;
    }
}
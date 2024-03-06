
public class GenerateTrees_Solution {
    public IList<TreeNode> GenerateTrees(int n) {
        var result = new List<TreeNode>();
        if(n == 0)
            return result;
        return GenerateTrees(1, n);
    }

    private IList<TreeNode> GenerateTrees(int v, int n)
    {
        var result = new List<TreeNode>();
        if(v > n) {
            result.Add(null!);
            return result;
        }
        for(var i = v; i <= n; i++) {
            var left = GenerateTrees(v, i - 1);
            var right = GenerateTrees(i + 1, n);
            foreach(var l in left) {
                foreach(var r in right) {
                    var current = new TreeNode(i)
                    {
                        left = l,
                        right = r
                    };
                    result.Add(current);
                }
            }
        }
        return result;
    }
}
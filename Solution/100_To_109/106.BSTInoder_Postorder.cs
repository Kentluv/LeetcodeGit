
public class BuildTreeII_Solution {
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        var map = new Dictionary<int, int>();
        for(var i = 0; i < inorder.Length; i++) {
            map[inorder[i]] = i;
        }
        return BuildTree(inorder, 0, inorder.Length - 1, postorder, 0, postorder.Length - 1, map);
    }

    private TreeNode BuildTree(int[] inorder, int v1, int v2, int[] postorder, int v3, int v4, Dictionary<int, int> map)
    {
        if(v1 > v2 || v3 > v4)
            return null!;
        var root = new TreeNode(postorder[v4]);
        var index = map[root.val];
        var leftCount = index - v1;
        root.left = BuildTree(inorder, v1, index - 1, postorder, v3, v3 + leftCount - 1, map);
        root.right = BuildTree(inorder, index + 1, v2, postorder, v3 + leftCount, v4 - 1, map);
        return root;
    }
}

public class BuildTree_Solution {
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        var map = new Dictionary<int, int>();
        for(var i = 0; i < inorder.Length; i++) {
            map[inorder[i]] = i;
        }
        return BuildTree(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1, map);
    }

    private TreeNode BuildTree(int[] preorder, int v1, int v2, int[] inorder, int v3, int v4, Dictionary<int, int> map)
    {
        if(v1 > v2 || v3 > v4)
            return null!;
        var root = new TreeNode(preorder[v1]);
        var index = map[root.val];
        var leftCount = index - v3;
        root.left = BuildTree(preorder, v1 + 1, v1 + leftCount, inorder, v3, index - 1, map);
        root.right = BuildTree(preorder, v1 + leftCount + 1, v2, inorder, index + 1, v4, map);
        return root;
    }
}
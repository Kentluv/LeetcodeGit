
public class SortedArrayToBST_Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        var results = new TreeNode(0);
        if(nums.Length == 0)
            return null!;
        return BuildTree(nums, 0, nums.Length - 1);
    }

    private TreeNode BuildTree(int[] nums, int v1, int v2)
    {
        if(v1 > v2)
            return null!;
        var mid = v1 + (v2 - v1) / 2;
        var root = new TreeNode(nums[mid]);
        root.left = BuildTree(nums, v1, mid - 1);
        root.right = BuildTree(nums, mid + 1, v2);
        return root;
    }
}
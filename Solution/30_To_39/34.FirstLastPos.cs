public class SearchRange_Solution {
    public int[] SearchRange(int[] nums, int target) {
        var f = Array.IndexOf(nums, target);
        var l = Array.LastIndexOf(nums, target);
        return [f, l];
    }
}
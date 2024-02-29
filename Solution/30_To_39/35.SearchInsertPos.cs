public class SearchInsert_Solution {
    public int SearchInsert(int[] nums, int target) {
        var index = Array.BinarySearch(nums, target);
        if (index >= 0) {
            return index;
        } else {
            return ~index;
        }
    }
}
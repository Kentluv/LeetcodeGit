public class SearchInRotate_Solution {
    public int Search(int[] nums, int target) {
        //Solution 1
        // var left = 0;
        // var right = nums.Length - 1;
        // while (left <= right) {
        //     var mid = left + (right - left) / 2;
        //     if (nums[mid] == target) {
        //         return mid;
        //     }
        //     if (nums[left] <= nums[mid]) {
        //         if (nums[left] <= target && target < nums[mid]) {
        //             right = mid - 1;
        //         } else {
        //             left = mid + 1;
        //         }
        //     } else {
        //         if (nums[mid] < target && target <= nums[right]) {
        //             left = mid + 1;
        //         } else {
        //             right = mid - 1;
        //         }
        //     }
        // }
        // return -1;

        //Solution 2
        return Array.IndexOf(nums, target);
    }
}
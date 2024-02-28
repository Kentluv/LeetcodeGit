public class ThreeSumClosest_Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int closest = int.MaxValue;
        int result = 0;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++) {
            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right) {
                int sum = nums[i] + nums[left] + nums[right];
                if (Math.Abs(sum - target) < closest) {
                    closest = Math.Abs(sum - target);
                    result = sum;
                }
                if (sum < target) {
                    left++;
                } else if (sum > target) {
                    right--;
                } else {
                    return sum;
                }
            }
        }
        return result;
    }
}
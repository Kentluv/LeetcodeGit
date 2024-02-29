public class RemoveDuplicates_Solution {
    public int RemoveDuplicates(int[] nums) {
        var count = 0;
        for (var i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[count]) {
                count++;
                nums[count] = nums[i];
            }
        }
        return count + 1;
    }
}
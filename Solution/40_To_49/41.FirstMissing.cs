public class FirstMissingPositive_Solution {
    public int FirstMissingPositive(int[] nums) {
        var i = 0;
        while (i < nums.Length){
            if (nums[i] > 0 && nums[i] <= nums.Length && nums[nums[i] - 1] != nums[i]){
                var temp = nums[nums[i] - 1];
                nums[nums[i] - 1] = nums[i];
                nums[i] = temp;
            }
            else{
                i++;
            }
        }
        for (i = 0; i < nums.Length; i++){
            if (nums[i] != i + 1){
                return i + 1;
            }
        }
        return nums.Length + 1;
    }
}
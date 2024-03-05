public class SortColors_Solution {
    public void SortColors(int[] nums) {
        for(var i = 0; i < nums.Length; i++){
            for(var j = i + 1; j < nums.Length; j++){
                if(nums[i] > nums[j]){
                    var temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
    }
}

public class RemoveElement_Solution {
    public int RemoveElement(int[] nums, int val) {
        // Solution 1
        // var count = 0;
        // for (var i = 0; i < nums.Length; i++) {
        //     if (nums[i] != val) {
        //         nums[count] = nums[i];
        //         count++;
        //     }
        // }
        // return count;

        // Solution 2
        var i = 0;
        var n = nums.Length;
        while (i < n) {
            if (nums[i] == val) {
                nums[i] = nums[n - 1];
                n--;
            } else {
                i++;
            }
        }
        return n;
    }
}
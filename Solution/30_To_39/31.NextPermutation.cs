public class NextPermutation_Solution {
    public void NextPermutation(int[] nums) {
        // Next Permutation
        // 1. Find the largest index k such that a[k] < a[k + 1]. If no such index exists, the permutation is the last permutation.
        // 2. Find the largest index l greater than k such that a[k] < a[l].
        // 3. Swap the value of a[k] with that of a[l].
        // 4. Reverse the sequence from a[k + 1] up to and including the final element a[n].
        int k = -1;
        for (int i = nums.Length - 2; i >= 0; i--) {
            if (nums[i] < nums[i + 1]) {
                k = i;
                break;
            }
        }
        if (k == -1) {
            Array.Reverse(nums);
            return;
        }
        int l = -1;
        for (int i = nums.Length - 1; i > k; i--) {
            if (nums[i] > nums[k]) {
                l = i;
                break;
            }
        }
        int temp = nums[k];
        nums[k] = nums[l];
        nums[l] = temp;
        Array.Reverse(nums, k + 1, nums.Length - k - 1);
        return;

    }
}
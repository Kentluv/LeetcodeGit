public class FindMedianSortedArrays_Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var mergedArray = nums1.Concat(nums2).ToArray();
        Array.Sort(mergedArray);
        int length = mergedArray.Length;
        if (length % 2 == 0)
        {
            return (mergedArray[length / 2 - 1] + mergedArray[length / 2]) / 2.0;
        }
        else
        {
            return mergedArray[length / 2];
        }
    }
}
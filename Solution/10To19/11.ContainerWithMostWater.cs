public class MaxArea_Solution {
    public int MaxArea(int[] height) {
        var max = 0;
        var left = 0;
        var right = height.Length - 1;
        while (left < right) {
            var valLeft = height[left];
            var valRight = height[right];
            var area = (right - left) * Math.Min(valLeft, valRight);
            max = Math.Max(max, area);
            if (valLeft < valRight) {
                left++;
            } else {
                right--;
            }
        }
        return max;
    }
}

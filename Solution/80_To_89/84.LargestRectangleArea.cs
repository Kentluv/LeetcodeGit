public class LargestRectangleArea_Solution {
    public int LargestRectangleArea(int[] heights) {
        var stack = new Stack<int>();
        int maxArea = 0;
        for (int i = 0; i <= heights.Length; i++) {
            int h = (i == heights.Length) ? 0 : heights[i];
            if (stack.Count == 0 || h >= heights[stack.Peek()]) {
                stack.Push(i);
            } else {
                int top = stack.Pop();
                maxArea = Math.Max(maxArea, heights[top] * (stack.Count == 0 ? i : i - 1 - stack.Peek()));
                i--;
            }
        }
        return maxArea;
    }
}
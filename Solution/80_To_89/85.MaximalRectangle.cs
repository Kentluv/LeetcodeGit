public class MaximalRectangle_Solution {
    public int MaximalRectangle(char[][] matrix) {
        var heights = new int[matrix[0].Length];
        int maxArea = 0;
        for (int i = 0; i < matrix.Length; i++) {
            for (int j = 0; j < matrix[0].Length; j++) {
                if (matrix[i][j] == '1') {
                    heights[j]++;
                } else {
                    heights[j] = 0;
                }
            }
            maxArea = Math.Max(maxArea, LargestRectangleArea(heights));
        }
        return maxArea;
    }

    private int LargestRectangleArea(int[] heights)
    {
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
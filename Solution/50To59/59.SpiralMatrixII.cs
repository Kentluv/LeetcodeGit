public class GenerateMatrix_Solution {
    public int[][] GenerateMatrix(int n) {
        var result = new int[n][];
        int left = 0, right = n - 1, top = 0, bottom = n - 1;
        for (int i = 0; i < n; i++)
        {
            result[i] = new int[n];;
        }

        int num = 1;
        while (num <= n * n)
        {
            for (int i = left; i <= right; i++)
            {
                result[top][i] = num++;
            }
            top++;
            for (int i = top; i <= bottom; i++)
            {
                result[i][right] = num++;
            }
            right--;
            for (int i = right; i >= left; i--)
            {
                result[bottom][i] = num++;
            }
            bottom--;
            for (int i = bottom; i >= top; i--)
            {
                result[i][left] = num++;
            }
            left++;
        }

        return result;
    }
}
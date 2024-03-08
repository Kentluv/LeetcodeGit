public class MinimumTotal_Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        // var sum = 0;
        // var count = triangle.Count;
        // if(count == 0) return sum;
        // if(count == 1) return triangle[0][0];
        // foreach(var row in triangle)
        // {
        //     sum += row.Min();
        // }
        // return sum;

        var count = triangle.Count;
        if(count == 0) return 0;
        if(count == 1) return triangle[0][0];
        for(int i = count - 2; i >= 0; i--)
        {
            for(int j = 0; j <= i; j++)
            {
                triangle[i][j] += Math.Min(triangle[i + 1][j], triangle[i + 1][j + 1]);
            }
        }
        return triangle[0][0];
    }
}
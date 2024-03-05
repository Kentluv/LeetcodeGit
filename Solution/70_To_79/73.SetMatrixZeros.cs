public class SetZeroes_Solution
{
    public void SetZeroes(int[][] matrix)
    {
        var rows = matrix.Length;
        var columns = matrix[0].Length;
        var lstRows = new List<int>();
        var lstColumns = new List<int>();
        for (var i = 0; i < rows; i++)
            for (var j = 0; j < columns; j++)
            {
                if (matrix[i][j] == 0)
                {
                    if(!lstRows.Contains(i)) lstRows.Add(i);
                    if(!lstColumns.Contains(j)) lstColumns.Add(j);
                }
            }

        foreach (var row in lstRows)
            for (var j = 0; j < columns; j++)
            {
                matrix[row][j] = 0;
            }

        foreach (var column in lstColumns)
            for (var i = 0; i < rows; i++)
            {
                matrix[i][column] = 0;
            }
    }
}
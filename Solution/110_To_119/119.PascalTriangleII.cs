public class GetRow_Solution {
    public IList<int> GetRow(int rowIndex) {
        var results = new List<IList<int>>();
        for (int i = 0; i <= rowIndex; i++)
        {
            var row = new List<int>();
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    row.Add(1);
                }
                else
                {
                    row.Add(results[i - 1][j - 1] + results[i - 1][j]);
                }
            }
            results.Add(row);
        }
        return results[rowIndex];
    }
}
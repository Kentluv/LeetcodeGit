
public class Combine_Solution {
    public IList<IList<int>> Combine(int n, int k) {
        var result = new List<IList<int>>();
        var range = Enumerable.Range(1, n).ToArray();
        var current = new List<int>();
        Combine(range, k, 0, current, result);
        return result;
    }

    private void Combine(int[] range, int k, int v, List<int> current, List<IList<int>> result)
    {
        if (k == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = v; i < range.Length; i++)
        {
            current.Add(range[i]);
            Combine(range, k - 1, i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}
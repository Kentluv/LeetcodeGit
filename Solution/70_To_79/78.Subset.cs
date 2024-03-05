
public class Subsets_Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var result = new List<IList<int>>();
        var current = new List<int>();
        Subsets(nums, 0, current, result);
        return result;
    }

    private void Subsets(int[] nums, int v, List<int> current, List<IList<int>> result)
    {
        result.Add(new List<int>(current));
        for (int i = v; i < nums.Length; i++)
        {
            current.Add(nums[i]);
            Subsets(nums, i + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}
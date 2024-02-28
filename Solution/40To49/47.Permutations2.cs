public class PermuteUnique_Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        if(nums == null || nums.Length == 0) return new List<IList<int>>();
        if(nums.Length == 1) return nums.Select(x => new List<int> {x}).ToList<IList<int>>();

        var result = new List<IList<int>>();
        Permute(nums, 0, result);
        return result;
    }

    private void Permute(int[] nums, int v, List<IList<int>> result)
    {
        if(v == nums.Length - 1)
        {
            result.Add(nums.ToList());
            return;
        }

        var set = new HashSet<int>();
        for (int i = v; i < nums.Length; i++)
        {
            if(set.Contains(nums[i])) continue;
            set.Add(nums[i]);
            Swap(nums, i, v);
            Permute(nums, v + 1, result);
            Swap(nums, i, v);
        }
    }

    private void Swap(int[] nums, int i, int v)
    {
        var temp = nums[i];
        nums[i] = nums[v];
        nums[v] = temp;
    }
}
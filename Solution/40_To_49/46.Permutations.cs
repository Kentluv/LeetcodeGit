

public class Permute_Solution {
    public IList<IList<int>> Permute(int[] nums) {
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

        for (int i = v; i < nums.Length; i++)
        {
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
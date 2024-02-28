public class CombinationSum2_Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        var result = new List<IList<int>>();
        Array.Sort(candidates);
        CombinationSum2Helper(candidates, target, 0, new List<int>(), result);
        return result;
    }

    private void CombinationSum2Helper(int[] candidates, int target, int v, List<int> list, List<IList<int>> result)
    {
        if (target == 0)
        {
            result.Add(new List<int>(list));
            return;
        }
        for (int i = v; i < candidates.Length; i++)
        {
            if (candidates[i] > target)
            {
                break;
            }
            if (i > v && candidates[i] == candidates[i - 1])
            {
                continue;
            }
            list.Add(candidates[i]);
            CombinationSum2Helper(candidates, target - candidates[i], i + 1, list, result);
            list.RemoveAt(list.Count - 1);
        }
    }
}
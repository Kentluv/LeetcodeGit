public class CombinationSum_Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var result = new List<IList<int>>();
        Array.Sort(candidates);
        CombinationSumHelper(candidates, target, 0, new List<int>(), result);
        return result;
    }

    private void CombinationSumHelper(int[] candidates, int target, int v, List<int> list, List<IList<int>> result)
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
            list.Add(candidates[i]);
            CombinationSumHelper(candidates, target - candidates[i], i, list, result);
            list.RemoveAt(list.Count - 1);
        }
    }
}
public class SubsetsWithDup_Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        var results = new List<IList<int>>();
        Array.Sort(nums);
        results.Add([]);
        var length = nums.Length;
        for (var i = 0; i < length; i++) {
            var count = 0;
            while (i + count < length && nums[i + count] == nums[i]) {
                count++;
            }
            var resultLength = results.Count;
            for (var j = 0; j < resultLength; j++) {
                var result = new List<int>(results[j]);
                for (var k = 0; k < count; k++) {
                    result.Add(nums[i]);
                    results.Add(new List<int>(result));
                }
            }
            i += count - 1;
        }
        return results;
    }
}
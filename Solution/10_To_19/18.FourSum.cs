public class FourSum_Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);
        List<IList<int>> result = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 3; i++)
        {

            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1])
                {
                    continue;
                }
                int k = j + 1;
                int l = nums.Length - 1;
                long sum = nums[i] + nums[j];
                while (k < l)
                {
                    if (sum + nums[k] + nums[l] < target)
                    {
                        k++;
                    }
                    else if (sum + nums[k] + nums[l] > target)
                    {
                        l--;
                    }
                    else
                    {
                        List<int> list = [nums[i], nums[j], nums[k], nums[l]];
                        result.Add(list);
                        while (k < l && nums[k] == list[2])
                        {
                            k++;
                        }
                        while (k < l && nums[l] == list[3])
                        {
                            l--;
                        }
                    }
                }
            }
        }
        return result;
    }
}
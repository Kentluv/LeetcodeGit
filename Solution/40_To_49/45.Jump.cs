public class Jump_Solution
{
    public int Jump(int[] nums)
    {
        var currEnd = 0;
        var currFarthest = 0;
        int count = 0;

        int i = 0;
        while (i < nums.Length - 1)
        {
            currFarthest = Math.Max(currFarthest, i + nums[i]);

            if (currEnd == i)
            {
                currEnd = currFarthest;
                count++;
            }

            i++;
        }

        return count;
    }
}
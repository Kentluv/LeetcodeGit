using System.Text;

public class GetPermutation_Solution
{
    public string GetPermutation(int n, int k)
    {
        var nums = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            nums.Add(i);
        }

        var factorial = new int[n];
        factorial[0] = 1;
        for (int i = 1; i < n; i++)
        {
            factorial[i] = factorial[i - 1] * i;
        }

        k--;
        var sb = new StringBuilder();
        for (int i = 1; i <= n; i++)
        {
            var index = k / factorial[n - i];
            sb.Append(nums[index]);
            nums.RemoveAt(index);
            k -= index * factorial[n - i];
        }

        return sb.ToString();
    }
}
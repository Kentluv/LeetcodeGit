
public class GenerateParenthesis_Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        var result = new List<string>();
        GenerateParenthesis(n, n, result, "");
        return result;
    }

    private void GenerateParenthesis(int left, int right, List<string> result, string curr)
    {
        if (left == 0 && right == 0)
        {
            result.Add(curr);
            return;
        }

        if (left > 0)
        {
            GenerateParenthesis(left - 1, right, result, curr + "(");
        }

        if (right > left)
        {
            GenerateParenthesis(left, right - 1, result, curr + ")");
        }
    }
}
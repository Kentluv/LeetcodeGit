public class LengthOfLongestSubstring_Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        char[] inputStringAsCharArray = s.ToCharArray();
        IList<char> longestSubString = new List<char>();
        int longestSubStringValue = 0;
        foreach (char c in inputStringAsCharArray)
        {
            if (!longestSubString.Contains(c))
            {
                longestSubString.Add(c);
            }
            else
            {
                int indexOfFoundChar = longestSubString.IndexOf(c);
                longestSubString = longestSubString.Skip(indexOfFoundChar + 1).ToList();
                longestSubString.Add(c);

            }

            longestSubStringValue = longestSubStringValue < longestSubString.Count ? longestSubString.Count : longestSubStringValue++;
        }

        return longestSubStringValue;
    }
}
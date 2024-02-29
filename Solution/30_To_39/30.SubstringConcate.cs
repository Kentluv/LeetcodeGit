public class FindSubstring_Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        var result = new List<int>();
        if(string.IsNullOrEmpty(s) || words.Length == 0) return result;
        var wordCount = words.Length;
        var wordLength = words[0].Length;
        var totalLength = wordCount * wordLength;
        var dict = new Dictionary<string, int>();
        foreach(var word in words)
        {
            if(dict.ContainsKey(word)) dict[word]++;
            else dict[word] = 1;
        }
        for(int i = 0; i <= s.Length - totalLength; i++)
        {
            var tempDict = new Dictionary<string, int>(dict);
            for(int j = i; j < i + totalLength; j += wordLength)
            {
                var word = s.Substring(j, wordLength);
                if(tempDict.ContainsKey(word))
                {
                    tempDict[word]--;
                    if(tempDict[word] == 0) tempDict.Remove(word);
                }
                else break;
            }
            if(tempDict.Count == 0) result.Add(i);
        }
        return result;
    }
}
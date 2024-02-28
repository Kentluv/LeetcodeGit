public class GroupAnagrams_Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();
        foreach (var str in strs)
        {
            var key = str.ToCharArray();
            Array.Sort(key);
            if(dict.ContainsKey(new string(key)))
            {
                dict[new string(key)].Add(str);
            }
            else
            {
                dict.Add(new string(key), new List<string> {str});
            }
        }
        return dict.Values.ToList<IList<string>>();
    }
}
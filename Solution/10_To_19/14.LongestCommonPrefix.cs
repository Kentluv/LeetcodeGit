public class LongestCommonPrefix_Solution {
    public string LongestCommonPrefix(string[] strs) {
        //Solution 1
        // if (strs.Length == 0) return "";
        // string prefix = strs[0];
        // for (int i = 1; i < strs.Length; i++) {
        //     var value = strs[i];
        //     while (value.IndexOf(prefix) != 0) {
        //         prefix = prefix.Substring(0, prefix.Length - 1);
        //         if (prefix.Length == 0) return "";
        //     }
        // }
        // return prefix;

        //Solution 2
        if (strs.Length == 0) return "";
        string prefix = strs[0];
        for (int i = 1; i < strs.Length; i++) {
            var value = strs[i];
            while (!value.StartsWith(prefix)) {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix.Length == 0) return "";
            }
        }
        return prefix;
    }
}
public class WildCard_Solution {
    public bool IsMatch(string s, string p) {
        // Solution 1: Recursion with memoization
        var dp = new bool[s.Length + 1, p.Length + 1];
        dp[0, 0] = true;
        for (var i = 1; i <= p.Length; i++){
            if (p[i - 1] == '*'){
                dp[0, i] = dp[0, i - 1];
            }
        }
        for (var i = 1; i <= s.Length; i++){
            for (var j = 1; j <= p.Length; j++){
                if (p[j - 1] == '*'){
                    dp[i, j] = dp[i - 1, j] || dp[i, j - 1];
                }
                else if (p[j - 1] == '?' || s[i - 1] == p[j - 1]){
                    dp[i, j] = dp[i - 1, j - 1];
                }
            }
        }
        return dp[s.Length, p.Length];
    }
}
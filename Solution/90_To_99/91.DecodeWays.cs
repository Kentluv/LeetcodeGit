public class NumDecodings_Solution {
    public int NumDecodings(string s) {
        var length = s.Length;
        var dp = new int[length + 1];
        dp[0] = 1;
        dp[1] = s[0] == '0' ? 0 : 1;
        for (var i = 2; i <= length; i++) {
            var oneDigit = int.Parse(s.Substring(i - 1, 1));
            var twoDigits = int.Parse(s.Substring(i - 2, 2));
            if (oneDigit >= 1) {
                dp[i] += dp[i - 1];
            }
            if (twoDigits >= 10 && twoDigits <= 26) {
                dp[i] += dp[i - 2];
            }
        }
        return dp[length];
    }
}
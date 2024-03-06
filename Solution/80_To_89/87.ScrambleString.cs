public class IsScramble_Solution {
    public bool IsScramble(string s1, string s2) {
        var n = s1.Length;
        if (n != s2.Length) {
            return false;
        }
        var dp = new bool[n, n, n + 1];
        for (var i = 0; i < n; i++) {
            for (var j = 0; j < n; j++) {
                dp[i, j, 1] = s1[i] == s2[j];
            }
        }
        for (var len = 2; len <= n; len++) {
            for (var i = 0; i <= n - len; i++) {
                for (var j = 0; j <= n - len; j++) {
                    for (var k = 1; k < len; k++) {
                        if (dp[i, j, k] && dp[i + k, j + k, len - k]) {
                            dp[i, j, len] = true;
                            break;
                        }
                        if (dp[i, j + len - k, k] && dp[i + k, j, len - k]) {
                            dp[i, j, len] = true;
                            break;
                        }
                    }
                }
            }
        }
        return dp[0, 0, n];
    }
}
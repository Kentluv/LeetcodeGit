public class IsMatch_Solution {
    public bool IsMatch(string s, string p) {
        //Solution 1
        // if (p.Length == 0) return s.Length == 0;
        // bool firstMatch = s.Length > 0 && (s[0] == p[0] || p[0] == '.');
        // if (p.Length >= 2 && p[1] == '*') {
        //     return IsMatch(s, p.Substring(2)) || (firstMatch && IsMatch(s.Substring(1), p));
        // } else {
        //     return firstMatch && IsMatch(s.Substring(1), p.Substring(1));
        // }

        //Solution 2
        bool[,] dp = new bool[s.Length + 1, p.Length + 1];
        dp[s.Length, p.Length] = true;
        for (int i = s.Length; i >= 0; i--) {
            for (int j = p.Length - 1; j >= 0; j--) {
                bool firstMatch = i < s.Length && (s[i] == p[j] || p[j] == '.');
                if (j + 1 < p.Length && p[j + 1] == '*') {
                    dp[i, j] = dp[i, j + 2] || firstMatch && dp[i + 1, j];
                } else {
                    dp[i, j] = firstMatch && dp[i + 1, j + 1];
                }
            }
        }
        return dp[0, 0];
    }
}
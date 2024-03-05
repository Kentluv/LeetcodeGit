public class MinDistance_Solution {
    public int MinDistance(string word1, string word2) {
        var m = word1.Length;
        var n = word2.Length;
        var arr1 = word1.ToCharArray();
        var arr2 = word2.ToCharArray();
        var dp = new int[m + 1, n + 1];
        for (var i = 0; i <= m; i++){
            dp[i, 0] = i;
        }
        for (var j = 0; j <= n; j++){
            dp[0, j] = j;
        }
        for (var i = 1; i <= m; i++){
            for (var j = 1; j <= n; j++){
                if (arr1[i - 1] == arr2[j - 1]){
                    dp[i, j] = dp[i - 1, j - 1];
                }
                else{
                    dp[i, j] = Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i, j - 1])) + 1;
                }
            }
        }
        return dp[m, n];       
    }
}
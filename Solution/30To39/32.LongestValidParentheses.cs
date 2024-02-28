public class Solution {
    public int LongestValidParentheses(string s) {
        //Solution 1
        // var result = 0;
        // var stack = new Stack<int>();
        // stack.Push(-1);
        // for (int i = 0; i < s.Length; i++) {
        //     if (s[i] == '(') {
        //         stack.Push(i);
        //     } else {
        //         stack.Pop();
        //         if (stack.Count == 0) {
        //             stack.Push(i);
        //         } else {
        //             result = Math.Max(result, i - stack.Peek());
        //         }
        //     }
        // }
        // return result;

        //Solution 2
        var count1 = s.Count(x => x == '(');
        var count2 = s.Count(x => x == ')');
        if (count1 == 0 || count2 == 0) {
            return 0;
        }
        var result = 0; 
        var dp = new int[s.Length];
        for (int i = 1; i < s.Length; i++) {
            if (s[i] == ')') {
                if (s[i - 1] == '(') {
                    dp[i] = (i >= 2 ? dp[i - 2] : 0) + 2;
                } else if (i - dp[i - 1] > 0 && s[i - dp[i - 1] - 1] == '(') {
                    dp[i] = dp[i - 1] + ((i - dp[i - 1]) >= 2 ? dp[i - dp[i - 1] - 2] : 0) + 2;
                }
                result = Math.Max(result, dp[i]);
            }
        }
        return result;
    }
}
public class ClimbStairs_Solution {
    public int ClimbStairs(int n) {
        var a = 1;
        var b = 2;
        if (n <= 2) return n;
        for (int i = 3; i <= n; i++)
        {
            var temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
}
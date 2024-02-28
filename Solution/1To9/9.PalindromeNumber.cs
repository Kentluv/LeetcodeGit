public class IsPalindrome_Solution {
    public bool IsPalindrome(int x) {
        //Solution 1
        // var str = x.ToString();
        // if(x < 0) return false;
        // if(str.Length == 1) return true;
        // var reversed = new string(str.Reverse().ToArray());
        // return str == reversed;

        //Solution 2
        // if(x < 0) return false;
        // var reversed = 0;
        // var original = x;
        // while(x != 0) {
        //     var digit = x % 10;
        //     reversed = reversed * 10 + digit;
        //     x /= 10;
        // }
        // return original == reversed;

        //Solution 3
        if(x < 0 || (x % 10 == 0 && x != 0)) return false;
        var reversed = 0;
        while(x > reversed) {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }
        return x == reversed || x == reversed / 10;
    }
}
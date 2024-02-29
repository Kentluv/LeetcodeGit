public class MyAtoi_Solution {
    public int MyAtoi(string s) {
        var str = s.Trim();
        if (str.Length == 0) {
            return 0;
        }
        var isNegative = str[0] == '-';
        if (isNegative || str[0] == '+')
            str = str.Substring(1);
        
        // Remove leading zeros
        var i = 0;
        while (i < str.Length && str[i] == '0') {
            i++;
        }
        str = str.Substring(i);
        if (str.Length == 0) {
            return 0;
        }
        var j = 0;
        while (j < str.Length && char.IsDigit(str[j])) {
            j++;
        }
        str = str.Substring(0, j);
        if (str.Length == 0) {
            return 0;
        }
        if (str.Length > 10) {
            return isNegative ? int.MinValue : int.MaxValue;
        }
        if (long.TryParse(str, out var res)) {
            res = isNegative ? -res : res;
            if (res < int.MinValue) 
                return int.MinValue;
            if (res > int.MaxValue) 
                return int.MaxValue;
            return (int)res;
        }
        return 0;
    }
}
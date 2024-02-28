public class Reverse_Solution {
    public int Reverse(int x) {
        var str = x.ToString();
        var isNegative = str[0] == '-';
        if (isNegative) {
            str = str.Substring(1);
        }
        var arr = str.ToCharArray();
        Array.Reverse(arr);
        var result = new string(arr);
        if (isNegative) {
            result = "-" + result;
        }
        if (int.TryParse(result, out var res)) {
            return res;
        }
        return 0;
    }
}
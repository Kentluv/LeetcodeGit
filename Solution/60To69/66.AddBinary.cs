public class AddBinary_Solution {
    public string AddBinary(string a, string b) {
        var result = "";
        var carry = 0;
        var i = a.Length - 1;
        var j = b.Length - 1;
        while (i >= 0 || j >= 0 || carry > 0) {
            var sum = carry;
            if (i >= 0) {
                sum += a[i] - '0';
                i--;
            }
            if (j >= 0) {
                sum += b[j] - '0';
                j--;
            }
            carry = sum / 2;
            sum = sum % 2;
            result = sum + result;
        }
        return result;
    }
}
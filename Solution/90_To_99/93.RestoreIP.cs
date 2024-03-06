
public class RestoreIpAddresses_Solution {
    public IList<string> RestoreIpAddresses(string s) {
        var result = new List<string>();
        var length = s.Length;
        for (var i = 1; i < 4 && i < length - 2; i++) {
            for (var j = i + 1; j < i + 4 && j < length - 1; j++) {
                for (var k = j + 1; k < j + 4 && k < length; k++) {
                    var s1 = s.Substring(0, i);
                    var s2 = s.Substring(i, j - i);
                    var s3 = s.Substring(j, k - j);
                    var s4 = s.Substring(k);
                    if (IsValid(s1) && IsValid(s2) && IsValid(s3) && IsValid(s4)) {
                        result.Add($"{s1}.{s2}.{s3}.{s4}");
                    }
                }
            }
        }
        return result;
    }

    private bool IsValid(string s1)
    {
        if (s1.Length > 3 || s1.Length == 0 || (s1[0] == '0' && s1.Length > 1) || int.Parse(s1) > 255)
            return false;
        return true;
    }
}
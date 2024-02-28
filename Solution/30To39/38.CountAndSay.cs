public class CountAndSay_Solution {
    public string CountAndSay(int n) {
        var result = "1";
        for (int i = 1; i < n; i++) {
            result = CountAndSayHelper(result);
        }
        return result;
    }

    private string CountAndSayHelper(string input) {
        var result = "";
        var count = 1;
        for (int i = 0; i < input.Length; i++) {
            if (i + 1 < input.Length && input[i] == input[i + 1]) {
                count++;
            } else {
                result += count.ToString() + input[i];
                count = 1;
            }
        }
        return result;
    }
}
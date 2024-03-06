public class GrayCode_Solution {
    public IList<int> GrayCode(int n) {
        var result = new List<int> {0};
        for (var i = 0; i < n; i++) {
            var add = 1 << i;
            for (var j = result.Count - 1; j >= 0; j--) {
                result.Add(result[j] + add);
            }
        }
        return result;
    }
}
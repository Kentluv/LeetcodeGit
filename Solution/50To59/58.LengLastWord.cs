public class LengthOfLastWord_Solution {
    public int LengthOfLastWord(string s) {
        return s.Split(' ').Where(x => !string.IsNullOrEmpty(x)).LastOrDefault()?.Length ?? 0;
    }
}
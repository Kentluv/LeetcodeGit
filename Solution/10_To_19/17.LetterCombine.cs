

using System.Reflection.PortableExecutable;

public class LetterCombinations_Solution {
    public IList<string> LetterCombinations(string digits) {
        var result = new List<string>();
        if (digits.Length == 0) {
            return result;
        }
        var map = new Dictionary<char, char[]> {
            {'2', new char[] {'a', 'b', 'c'}},
            {'3', new char[] {'d', 'e', 'f'}},
            {'4', new char[] {'g', 'h', 'i'}},
            {'5', new char[] {'j', 'k', 'l'}},
            {'6', new char[] {'m', 'n', 'o'}},
            {'7', new char[] {'p', 'q', 'r', 's'}},
            {'8', new char[] {'t', 'u', 'v'}},
            {'9', new char[] {'w', 'x', 'y', 'z'}}
        };

        var letter = map[digits[0]];
        if(digits.Length == 1) {
            return letter.Select(x => x.ToString()).ToList();
        }

        var next = LetterCombinations(digits.Substring(1));
        foreach (var l in letter) {
            foreach (var n in next) {
                result.Add(l + n);
            }
        }
        return result;
    }
}
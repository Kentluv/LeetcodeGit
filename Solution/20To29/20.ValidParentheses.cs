public class ValidParentheses_Solution {
    public bool IsValid(string s) {
        //Use a stack to keep track of the opening brackets
        var stack = new Stack<char>();
        foreach (var c in s) {
            if (c == '(' || c == '[' || c == '{') {
                stack.Push(c);
            } else if (c == ')' && (stack.Count == 0 || stack.Pop() != '(')) {
                return false;
            } else if (c == ']' && (stack.Count == 0 || stack.Pop() != '[')) {
                return false;
            } else if (c == '}' && (stack.Count == 0 || stack.Pop() != '{')) {
                return false;
            }
        }
        return stack.Count == 0;
    }
}
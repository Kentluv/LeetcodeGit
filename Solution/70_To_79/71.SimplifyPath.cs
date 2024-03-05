using System.Text;

public class SimplifyPath_Solution {
    public string SimplifyPath(string path) {
        var arr = path.Split('/');
        var stack = new Stack<string>();
        foreach (var item in arr)
        {
            if (item == "..")
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else if (item != "." && item != "")
            {
                stack.Push(item);
            }
        }
        var result = new StringBuilder();
        while (stack.Count > 0)
        {
            result.Insert(0, stack.Pop());
            result.Insert(0, "/");
        }
        return result.Length == 0 ? "/" : result.ToString();
    }
}
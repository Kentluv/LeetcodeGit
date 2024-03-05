using System.Globalization;

public class MinWindow_Solution
{
    public string MinWindow(string s, string t)
    {
        // var sLength = s.Length;
        // var tLength = t.Length;
        // if (sLength == 0 || tLength == 0 || sLength < tLength) return "";
        // if (s == t || (t.Length == 1 && s.IndexOf(t) != -1)) return t;

        // var remain = sLength - tLength;
        // var min = int.MaxValue;
        // var ret = string.Empty;

        // for (var i = 0; i <= remain; i++)
        // {
        //     if (!t.Contains(s[i]))
        //         continue;

        //     var step = tLength;
        //     var subStr = s.Substring(i, step);

        //     while (step <= sLength)
        //     {
        //         var temp = subStr;
        //         var count = 0;;
        //         for(var j = 0; j < tLength; j++){
        //             if (temp.Contains(t[j]))
        //             {
        //                 temp = temp.Remove(temp.IndexOf(t[j]), 1);
        //                 count++;
        //             }
        //         }

        //         if (count == tLength)
        //         {
        //             if (subStr.Length < min)
        //             {
        //                 min = subStr.Length;
        //                 ret = subStr;
        //             }
        //             break;
        //         }

        //         if (i + step >= sLength)
        //             break;

        //         subStr += s[i + step];
        //         step++;
        //     }
        // }
        // return ret;


        // Solution 2
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
            return "";

        int[] map = new int[128];
        foreach (char c in t.ToCharArray())
            map[c]++;

        int counter = t.Length, begin = 0, end = 0, head = 0, len = int.MaxValue;

        while (end < s.Length)
        {
            if (map[s[end++]]-- > 0)
                counter--;

            while (counter == 0)
            {
                if (end - begin < len)
                    len = end - (head = begin);

                if (map[s[begin++]]++ == 0)
                    counter++;
            }
        }

        return len == int.MaxValue ? "" : s.Substring(head, len);
    }
}

public class RomanToInt_Solution
{
    public int RomanToInt(string s)
    {
        var map = new Dictionary<char, int>  {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000},
        };

        int res = 0;
        var leng = s.Length;
        for (int i = 0; i < leng; i++)
        {
            var c = s[i];
            var val = map[c];
            var next = i + 1 < leng ? map[s[i + 1]] : 0;
            if (val < next)
            {
                res -= val;
            }
            else
            {
                res += val;
            }
        }
        return res;
    }
}
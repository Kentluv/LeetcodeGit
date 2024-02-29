public class IsNumber_Solution {
    public bool IsNumber(string s) {
        //Solution 1
        // var dec = decimal.TryParse(s, out _);
        // return dec;

        //Solution 2
        s = s.Trim();
        bool numberSeen = false;
        bool numberAfterE = true;
        bool pointSeen = false;
        bool eSeen = false;
        for (int i = 0; i < s.Length; i++)
        {
            if ('0' <= s[i] && s[i] <= '9')
            {
                numberSeen = true;
                numberAfterE = true;
            }
            else if (s[i] == '.')
            {
                if (eSeen || pointSeen)
                {
                    return false;
                }
                pointSeen = true;
            }
            else if (s[i] == 'e' || s[i] == 'E')
            {
                if (eSeen || !numberSeen)
                {
                    return false;
                }
                numberAfterE = false;
                eSeen = true;
            }
            else if (s[i] == '-' || s[i] == '+')
            {
                if (i != 0 && s[i - 1] != 'e' && s[i - 1] != 'E')
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        return numberSeen && numberAfterE;
    }
}
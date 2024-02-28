public class LongestPalindrome_Solution
{
    public string LongestPalindrome(string s)
    {
        //Solution 1
        int length = s.Length;
        if (length < 2)
            return s;

        int start = 0;
        int maxLength = 1;

        for (int i = 0; i < length;)
        {
            if (length - i <= maxLength / 2)
                break;

            int j = i;
            int k = i;

            while (k < length - 1 && s[k + 1] == s[k])
                k++;

            i = k + 1;

            while (k < length - 1 && j > 0 && s[k + 1] == s[j - 1])
            {
                k++;
                j--;
            }

            int newLength = k - j + 1;
            if (newLength > maxLength)
            {
                start = j;
                maxLength = newLength;
            }
        }

        return s.Substring(start, maxLength);


        //Solution 2
        // var arr = s.ToCharArray();
        // int leng = s.Length;
        // if (leng < 2)
        //     return s;
        // var longest = 0;
        // var temp = arr[0].ToString();
        // for (int i = 0; i < leng; i++)
        // {
        //     for (int j = leng - 1; j > i; j--)
        //     {
        //         var sub = s.Substring(i, j - i + 1);
        //         string reverse = new(sub.ToCharArray().Reverse().ToArray());
        //         if (sub == reverse && sub.Length > longest)
        //         {
        //             longest = sub.Length;
        //             temp = sub;
        //         }
        //     }
        // }
        // return temp;
    }
}

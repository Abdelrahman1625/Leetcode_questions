public class Solution {
    public bool IsPalindrome(string s) {
        var lastIndex = s.Length-1;
        bool result = true;
        for (int i = 0; i < s.Length ; i++)
        {
            if (!IsEqual(s, ref i, ref lastIndex))
            {
                result = false;
                break;
            }
            lastIndex--;
        }
        return result;
    }
    public bool IsEqual(string s, ref int i, ref int j)
    {
        if (i > s.Length - 1 || j < 0)
        {
            return true;
        }
        if (!char.IsLetterOrDigit(s[i]))
        {
            i++;
            return IsEqual(s, ref i, ref j);
        }
        if (!char.IsLetterOrDigit(s[j]))
        {
            j--;
            return IsEqual(s, ref i, ref j);
        }
        return char.ToLower(s[i]) == char.ToLower(s[j]);
    }
}
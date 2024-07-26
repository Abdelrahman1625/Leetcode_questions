public class Solution {
    public bool IsSubsequence(string s, string t) {
        int sx = 0 , ty = 0;
        while (sx < s.Length && ty < t.Length)
        {
            if(s[sx] == t[ty])
            {
                sx++;
            }
            ty++;
        }
        return sx == s.Length;  
    }
}

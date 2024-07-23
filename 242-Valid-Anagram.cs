public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        int[] charCountS = new int[26];
        int[] charCountT = new int[26];

        for (int i = 0; i < s.Length; i++) {
            charCountS[s[i] - 'a']++;
            charCountT[t[i] - 'a']++;
        }

        for (int i = 0; i < 26; i++) {
            if (charCountS[i] != charCountT[i]) 
            {
                return false;
            }
        }
        return true;
    }
}
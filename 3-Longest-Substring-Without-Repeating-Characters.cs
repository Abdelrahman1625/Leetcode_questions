public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (string.IsNullOrEmpty(s)) return 0;

        int[] charIndex = new int[128];
        Array.Fill(charIndex, -1);

        int maxLength = 0;
        int start = 0;

        for (int i = 0; i < s.Length; i++) {
            if (charIndex[s[i]] >= start) {
                start = charIndex[s[i]] + 1;
            }
            charIndex[s[i]] = i;
            maxLength = Math.Max(maxLength, i - start + 1);
        }

        return maxLength;
    }
}
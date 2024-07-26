public class Solution {
    public bool IsSubsequence(string s, string t) {
        int Si = 0, Ti = 0;
        while (Si < s.Length && Ti < t.Length) {
            if (s[Si] == t[Ti]) {
                Si++;
            }
            Ti++;
        }
        return Si == s.Length;
    }
}

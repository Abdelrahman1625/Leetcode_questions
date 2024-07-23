using System;
using System.Collections.Generic;

public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] words = s.Split(' ');
        if (pattern.Length != words.Length) {
            return false;
        }

        var dict = new Dictionary <char, string>();

        for (int i = 0; i < pattern.Length; i++) {
            if (dict.ContainsKey(pattern[i])) {
                if (dict[pattern[i]] != words[i]) {
                    return false;
                }
            }
            else if(dict.Values.Contains(words[i]))
            {
                return false;
            }
            else
            {
                dict.Add(pattern[i], words[i]);
            }
        }

        return true;
    }
}

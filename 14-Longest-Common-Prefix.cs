public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string curr = strs[0];
        for(int i = 1; i < strs.Length; i++)
        {
            string currPrefix = string.Empty;
            for(int j = 0; j < strs[i].Length; j++)
            {
                if(j >= curr.Length)break;
                if(strs[i][j] == curr[j])
                {
                    currPrefix += strs[i][j];
                }
                else
                {
                    break;
                }
            }
            curr = currPrefix;
        }
        return curr;
    }
}

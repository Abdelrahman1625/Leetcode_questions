public class Solution {
    public int RangeSum(int[] nums, int n, int left, int right) {
        const int MOD = 1000000007;        
        List<int> subarraySums = new List<int>();
        for (int i = 0; i < n; i++) {
            int sum = 0;
            for (int j = i; j < n; j++) {
                sum += nums[j];
                subarraySums.Add(sum);
            }
        }
        subarraySums.Sort();
        long result = 0;
        for (int i = left - 1; i < right; i++) {
            result = (result + subarraySums[i]) % MOD;
        }
        return (int)result;
    }
}
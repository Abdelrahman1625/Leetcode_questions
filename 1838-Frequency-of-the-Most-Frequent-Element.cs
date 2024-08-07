public class Solution {
    public int MaxFrequency(int[] nums, int k) {
        Array.Sort(nums);
        int left = 0;
        long sum = 0;
        int ans = 0;

        for (int right = 0; right < nums.Length; right++) {
            sum += nums[right];
            
            while (sum + k < (long)(right - left + 1) * nums[right]) {
                sum -= nums[left];
                left++;
            }

            ans = Math.Max(ans, right - left + 1);
        }

        return ans;
    }
}
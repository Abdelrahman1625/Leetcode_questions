public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int n = nums.Length;
        int left = 0, right = 0;
        int sum = 0;
        int minLen = n + 1;

        while (right < n) {
            sum += nums[right];

            while (sum >= target) {
                minLen = Math.Min(minLen, right - left + 1);
                sum -= nums[left];
                left++;
            }

            right++;
        }

        return minLen == n + 1 ? 0 : minLen;
    }
}

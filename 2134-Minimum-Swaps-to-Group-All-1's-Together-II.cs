public class Solution {
    public int MinSwaps(int[] nums) {
        int n = nums.Length;
        int totalOnes = nums.Sum();
        
        if (totalOnes == 0 || totalOnes == n) return 0;
        
        int currentOnes = 0;
        for (int i = 0; i < totalOnes; i++) {
            currentOnes += nums[i];
        }
        
        int maxOnes = currentOnes;
        
        for (int i = 0; i < n; i++) {
            currentOnes = currentOnes - nums[i] + nums[(i + totalOnes) % n];
            maxOnes = Math.Max(maxOnes, currentOnes);
        }
        
        return totalOnes - maxOnes;
    }
}
public class Solution {
    public int FindPeakElement(int[] nums) {
        int l = 0;
        int r = nums.Length - 1;
        
        while (l < r) {
            int i = l + (r - l) / 2;
            
            if (nums[i] > nums[i + 1]) {
                r = i;
            } else {
                l = i + 1;
            }
        }
        
        return l;
    }
}

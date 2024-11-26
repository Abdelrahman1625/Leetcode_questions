public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] outarray = new int[2];
        for (int i = 0; i < nums.Length; i++) {
            for(int j = i + 1; j < nums.Length; j++) {
                if (nums[i] + nums[j] == target) {
                    outarray[0] = i;
                    outarray[1] = j;
                    return outarray;
                }
            }
        }
        return outarray;
    }
}
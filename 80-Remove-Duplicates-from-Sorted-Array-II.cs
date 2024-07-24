public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length <= 2) return nums.Length;
        int j = 1; // start from the second element
        int count = 1; // count the occurrences of the current number

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] == nums[i - 1]) {
                count++;
            } else {
                count = 1;
            }

            if (count <= 2) {
                nums[j] = nums[i];
                j++;
            }
        }
        return j;
    }
}
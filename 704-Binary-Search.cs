public class Solution {
    public int Search(int[] nums, int target) {
        int index = 0;
        for(int i = 0; i< nums.Length; i++)
        {
            if(nums[i] == target)
            {
                index = i;
                return i;
            }
        }
        return -1;
    }
}
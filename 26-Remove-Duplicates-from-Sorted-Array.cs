public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int count = 0;
        int curNumber = int.MinValue;
        foreach (int x in nums)
        {
            if (curNumber != x)
            {
                count++;
                nums[count - 1] = x;
            }
            curNumber = x;
        }
        return count;
    }
}
public class Solution {
    public int FindMin(int[] nums) {
        var min = 100000000;
        for(var i =0; i < nums.Length; i++)
        {
            if(min > nums[i])
            {
                min = nums[i];
            }
        }
        return min;
    }
}
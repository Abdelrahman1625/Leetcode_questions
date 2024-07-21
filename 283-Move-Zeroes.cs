public class Solution {
    public void MoveZeroes(int[] nums) {
        int Last =0, cur=0;
        while(cur < nums.Length)
        {
            if(nums[cur] != 0)
            {
                int temp = nums[cur];
                nums[cur] = nums[Last];
                nums[Last]= temp;
                Last++;
            }
            cur++;
        }
    }
}
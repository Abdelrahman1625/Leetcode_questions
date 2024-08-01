public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        int count = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                if(nums[i] == nums[j])
                {
                    count = Math.Abs(i - j);
                    if(count <= k)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
}
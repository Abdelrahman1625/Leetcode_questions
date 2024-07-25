public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        for (var i = 0; i < numbers.Length; i++)
        {
            for (var j = 1; j < numbers.Length; j++)
            {
                if((numbers[i] + numbers[j] == target) && (i != j))
                {
                    return [i + 1 ,j + 1];
                }
            }
        }
        return [0];
    }
}
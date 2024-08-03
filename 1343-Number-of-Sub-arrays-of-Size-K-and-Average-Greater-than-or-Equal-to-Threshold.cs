public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        int count = 0;
        int sum = 0;
        
        for (int i = 0; i < k; i++) {
            sum += arr[i];
        }
        
        if (sum / k >= threshold) {
            count++;
        }
        
        for (int i = k; i < arr.Length; i++) {
            sum = sum - arr[i - k] + arr[i];
            if (sum / k >= threshold) {
                count++;
            }
        }
        return count;
    }
}
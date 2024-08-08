public class Solution {
    public int TotalFruit(int[] fruits) {
        int n = fruits.Length;
        int maxFruit = 0;
        Dictionary<int, int> basket = new Dictionary<int, int>();
        int left = 0, right = 0;

        while (right < n) {
            basket[fruits[right]] = basket.GetValueOrDefault(fruits[right], 0) + 1;

            while (basket.Count > 2) {
                basket[fruits[left]]--;
                if (basket[fruits[left]] == 0) {
                    basket.Remove(fruits[left]);
                }
                left++;
            }

            maxFruit = Math.Max(maxFruit, right - left + 1);
            right++;
        }

        return maxFruit;
    }
}
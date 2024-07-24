public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int maxBananas = 0;
        foreach (int pile in piles)
        {
            if (pile > maxBananas)
                maxBananas = pile;
        }

        int left = 1, right = maxBananas;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            int hours = 0;
            foreach (int pile in piles)
            {
                hours += (pile + mid - 1) / mid;
            }

            if (hours <= h)
                right = mid;
            else
                left = mid + 1;
        }

        return left;
    }
}

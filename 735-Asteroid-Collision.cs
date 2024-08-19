public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        var s = new Stack<int>();

        foreach (int asteroid in asteroids)
        {
            bool destroy = false;
            while (s.Count > 0 && asteroid < 0 && s.Peek() > 0)
            {
                if (s.Peek() < Math.Abs(asteroid))
                {
                    s.Pop();
                    continue;
                }
                else if (s.Peek() == Math.Abs(asteroid))
                {
                    s.Pop();
                }
                destroy = true;
                break;
            }

            if (!destroy)
            {
                s.Push(asteroid);
            }
        }

        return s.Reverse().ToArray();
    }
}
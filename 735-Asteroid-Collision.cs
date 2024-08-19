public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        var stack = new Stack<int>();

        foreach (int asteroid in asteroids)
        {
            bool destroy = false;
            while (stack.Count > 0 && asteroid < 0 && stack.Peek() > 0)
            {
                if (stack.Peek() < -asteroid)
                {
                    stack.Pop();
                    continue;
                }
                else if (stack.Peek() == -asteroid)
                {
                    stack.Pop();
                }
                destroy = true;
                break;
            }

            if (!destroy)
            {
                stack.Push(asteroid);
            }
        }

        return stack.Reverse().ToArray();
    }
}
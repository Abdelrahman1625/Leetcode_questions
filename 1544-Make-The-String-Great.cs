public class Solution {
    public string MakeGood(string s) 
    {
        var stack = new Stack<char>();
        foreach(char c in s)
        {
            if (stack.Count > 0 && char.ToLower(stack.Peek()) == char.ToLower(c) && stack.Peek() != c)
            {
                stack.Pop();
            }
            else
            {
                stack.Push(c);
            }
        }
        return new string(stack.Reverse().ToArray());
    }
}
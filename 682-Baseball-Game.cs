public class Solution {
    public int CalPoints(string[] operations) {
        var stack = new Stack<int>();
        foreach (var op in operations)
        {
            if(int.TryParse(op, out int num))
            {
                stack.Push(num);
            }
            else
            {
                switch(op)
                {
                    case \+\:
                    var second = stack.Pop();
                        var first = stack.Peek();
                        stack.Push(second);
                        stack.Push(first + second);
                        break;
                    case \D\:
                        stack.Push(stack.Peek() * 2);
                        break;
                    case \C\:
                        stack.Pop();
                        break;
                }
            }
        }
        return stack.Sum();
    }
}
/*--------------------------------*/
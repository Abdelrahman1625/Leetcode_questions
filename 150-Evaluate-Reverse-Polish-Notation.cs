public class Solution {
    public int EvalRPN(string[] tokens) {
        var s = new Stack<int>();
        foreach(string t in tokens)
        {
            if(int.TryParse(t, out int number))
            {
                s.Push(number);
            }
            else{
                int b = s.Pop();
                int a = s.Pop();
                
                switch (t) {
                    case \+\:
                        s.Push(a + b);
                        break;
                    case \-\:
                        s.Push(a - b);
                        break;
                    case \*\:
                        s.Push(a * b);
                        break;
                    case \/\:
                        s.Push(a / b);
                        break;
                }
            }
        }
        return s.Pop();
    }
}
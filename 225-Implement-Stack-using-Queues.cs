public class MyStack {

    private Queue<int> queue1;
    private Queue<int> queue2;

    public MyStack() { 
        queue1 = new Queue<int>();
        queue2 = new Queue<int>();
    }

    public void Push(int x) {
        queue2.Enqueue(x);
        while (queue1.Count != 0) {
            queue2.Enqueue(queue1.Dequeue());
        }
        Queue<int> temp = queue1;
        queue1 = queue2;
        queue2 = temp;
    }

    public int Pop() {
        if (queue1.Count == 0) {
            throw new InvalidOperationException(\Stack is empty\);
        }
        return queue1.Dequeue();
    }

    public int Top() {
        if (queue1.Count == 0) {
            throw new InvalidOperationException(\Stack is empty\);
        }
        return queue1.Peek();
    }

    public bool Empty() {
        return queue1.Count == 0;
    }
}


/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
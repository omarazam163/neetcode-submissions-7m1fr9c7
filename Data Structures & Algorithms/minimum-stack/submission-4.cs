public class MinStack {

   Stack<int> stack;
        Stack<int> minStack;
        public MinStack()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int val)
        {
            stack.Push(val);
            if(minStack.Count==0)
            {
                minStack.Push(val);
            }
            else
            {
                if(minStack.Peek()>=val) minStack.Push(val); // [1,0]
            }
        }

        public void Pop()
        {
            int val = stack.Pop();
            if(minStack.TryPeek(out int x))
            {
                if(x==val) minStack.Pop();
            }
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return minStack.Peek();
        }
}

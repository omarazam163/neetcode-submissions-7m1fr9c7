    public class MinStack
    {
        private List<int> _stack;
        public MinStack()
        {
            this._stack = new List<int>();
        }
        public void Push(int val)
        {
             this._stack.Add(val);
        }
        public void Pop()
        {
            this._stack.RemoveAt(_stack.Count-1);
        }
        public int Top()
        {
            return this._stack[this._stack.Count-1];
        }
        public int GetMin()
        {
            return this._stack.Min();
        }
    }
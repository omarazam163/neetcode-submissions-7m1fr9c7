    public class MinStack
    {
        private List<Tuple<int,int>> _stack;
        int min;
        public MinStack()
        {
            this._stack = new();
        }
        public void Push(int val)
        {
             if (this._stack.Count == 0) min = val;
             this._stack.Add(new Tuple<int, int>(val,min));
             if (min > val) min = val;
        }
        public void Pop()
        {
            min = this._stack[this._stack.Count - 1].Item2;
            this._stack.RemoveAt(_stack.Count - 1);
        }
        public int Top()
        {
            return this._stack[this._stack.Count - 1].Item1;
        }
        public int GetMin()
        {
            return min;
        }
    }
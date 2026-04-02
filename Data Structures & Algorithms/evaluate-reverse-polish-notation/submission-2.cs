    public class Solution
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();
            for(int i=0;i<tokens.Length;i++)
            {
                if (int.TryParse(tokens[i],out int val))
                {
                    stack.Push(val);
                }
                else
                {
                    int op2 = stack.Pop();
                    int op1 = stack.Pop();
                    int res=0;
                    if (tokens[i] == "+") res = op1 + op2;
                    else if (tokens[i] == "-") res = op1 - op2;
                    else if (tokens[i] == "*") res = op1 * op2;
                    else if (tokens[i] == "/") res = op1 / op2;
                    stack.Push(res);
                }
            }
            return stack.Peek();
        }
    }
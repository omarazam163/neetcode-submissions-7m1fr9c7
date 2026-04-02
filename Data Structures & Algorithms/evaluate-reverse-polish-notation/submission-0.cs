public class Solution {
            public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new();
            string[] operands = { "+", "-", "*", "/" };
            foreach (string op in tokens)
            {
                if (operands.Any((x) => x == op))
                {
                    int op1 = Convert.ToInt32(stack.Pop());
                    int op2 = Convert.ToInt32(stack.Pop());
                    int res = 0;
                    if (op == "+") res = op1 + op2;
                    else if (op == "-") res = op2 - op1;
                    else if (op == "*") res = op2 * op1;
                    else if (op == "/") res = op2 / op1;
                    stack.Push(res);
                }
                else
                {
                    stack.Push(Convert.ToInt32(op));
                }
            }
            return stack.Pop();
        }
}

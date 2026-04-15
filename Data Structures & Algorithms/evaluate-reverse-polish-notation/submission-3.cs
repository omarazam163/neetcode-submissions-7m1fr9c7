public class Solution {
        public int EvalRPN(string[] tokens)
        {
            var stack = new Stack<int>();

            foreach (var str in tokens)
            {
                if (int.TryParse(str, out int number))
                {
                    stack.Push(number);
                }

                else
                {
                    var op1 = stack.Pop();
                    var op2 = stack.Pop();
                    var res = 0;
                    if (str == "+")
                    {
                        res = op1 + op2;
                    }
                    else if (str == "-")
                    {
                        res = op2 - op1;
                    }
                    else if (str == "*")
                        res = op1 * op2;
                    else if (str == "/")
                        res = op2 / op1;

                    stack.Push(res);
                }
            }

            return stack.Peek();
        }
}

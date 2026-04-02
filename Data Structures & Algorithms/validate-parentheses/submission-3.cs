    public class Solution
    {
                public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '{' || c == '[' || c == '(')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        if (stack.Peek() == '[' && c == ']') stack.Pop();
                        else if (stack.Peek() == '{' && c == '}') stack.Pop();
                        else if (stack.Peek() == '(' && c == ')') stack.Pop();
                        else return false;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
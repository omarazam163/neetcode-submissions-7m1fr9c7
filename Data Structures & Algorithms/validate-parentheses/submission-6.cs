public class Solution {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            foreach(var c in s)
            {
                if(c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }

                else
                {
                    if (stack.TryPeek(out char peek))
                    {
                        if (peek == '(' && c == ')')
                            stack.Pop();
                        else if (peek == '{' && c == '}')
                            stack.Pop();
                        else if (peek == '[' && c == ']')
                            stack.Pop();
                        else
                            return false;
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

    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new();
            if(s.Length%2!=0) return false;
            if(s.StartsWith('}') || s.StartsWith(')') || s.StartsWith("]")) return false;
            stack.Push(s[0]);
            for(int i=1;i<s.Length;i++)
            {
                if (s[i] == '{' || s[i] == '(' || s[i] == '[') stack.Push(s[i]);
                if (s[i] == '}' || s[i] == ')' || s[i] == ']')
                {
                    if (stack.Count == 0) return false;
                    char top = stack.Pop();
                    if ((s[i] == '}' && top != '{') || (s[i] == ')' && top != '(') || (s[i] == ']' && top != '[')) return false;
                }
            }
            return stack.Count == 0;
        }
    }
public class Solution {
        public bool IsPalindrome(string s)
        {
            var skip = (char x) => !(char.IsLetter(x) || char.IsNumber(x));
            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                if (skip(s[start]))
                {
                    start++;
                    continue;
                }
                if (skip(s[end]))
                {
                    end--;
                    continue;
                }
                if (char.ToLower(s[start]) !=  char.ToLower(s[end]))
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
}


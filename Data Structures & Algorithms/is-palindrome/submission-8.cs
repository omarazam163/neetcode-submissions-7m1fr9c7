public class Solution {
        public bool IsPalindrome(string s)
        {
            var sentence = s.Where(x => char.IsLetter(x) || char.IsNumber(x)).ToList();
            int start = 0;
            int end = sentence.Count - 1;

            while (start < end)
            {
                if (char.ToLower(sentence[start]) !=  char.ToLower(sentence[end]))
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
}


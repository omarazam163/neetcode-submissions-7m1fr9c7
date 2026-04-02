    public class Solution
    {
        HashSet<string> final = new();
        List<List<char>> map = new();
        void solve(int i,int digit,StringBuilder sb)
        {
            if (digit >= map.Count) {
                final.Add(sb.ToString());
                return;
            };
            if (i >= map[digit].Count) return;
            //take
            for (int j = 0; j < map.Count; j++)
            {
                sb.Append(map[digit][i]);
                solve(j, digit + 1, sb);
                sb.Remove(sb.Length - 1, 1);
            }

            //leave

            solve(i+1, digit, sb);
        }

        public List<string> LetterCombinations(string digits)
        {
             if (digits.Length == 0) return new List<string>();
            Dictionary<char, List<char>> keypadMapping = new Dictionary<char, List<char>>() {
            {'2', new List<char>{'a', 'b', 'c'}},
            {'3', new List<char>{'d', 'e', 'f'}},
            {'4', new List<char>{'g', 'h', 'i'}},
            {'5', new List<char>{'j', 'k', 'l'}},
            {'6', new List<char>{'m', 'n', 'o'}},
            {'7', new List<char>{'p', 'q', 'r', 's'}},
            {'8', new List<char>{'t', 'u', 'v'}},
            {'9', new List<char>{'w', 'x', 'y', 'z'}},
            };

            foreach(var x in digits)
            {
                map.Add(keypadMapping[x]);
            }

            solve(0, 0, new StringBuilder());
            return final.ToList();
        }
    }
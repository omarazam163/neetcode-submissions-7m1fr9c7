    public class Solution
    {
        List<List<char>> map = new();
        List<string> res = new();
        StringBuilder sp = new();
        string digits; 
        void solve(int i)
        {
            if(i>=digits.Length)
            {
                res.Add(sp.ToString());
                return;
            }

            foreach(char x in map[i])
            {
                sp.Append(x);
                solve(i+1);
                sp.Remove(sp.Length-1,1);
            }
        }
        public List<string> LetterCombinations(string digits)
        {
            this.digits = digits;
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

            foreach (var x in digits)
            {
                map.Add(keypadMapping[x]);
            }
            solve(0);
            return res;
        }
    }
    public class Solution
    {
        static void check(string s, Dictionary<char, int> keyValuePairs)
        {
            foreach (char c in s)
            {
                if (keyValuePairs.ContainsKey(c))
                {
                    keyValuePairs[c]++;
                }
                else
                {
                    keyValuePairs.Add(c, 1);
                }
            }
        }
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> keyValuePairs1 = new Dictionary<char, int>();
            Dictionary<char, int> keyValuePairs2 = new Dictionary<char, int>();
            check(s, keyValuePairs1);
            check(t, keyValuePairs2);
            if (keyValuePairs1.Count != keyValuePairs2.Count)
            {
                return false;
            } 
            foreach (char c in keyValuePairs1.Keys)
            {
                if (keyValuePairs2.ContainsKey(c))
                {
                    if (keyValuePairs1[c] == keyValuePairs2[c])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
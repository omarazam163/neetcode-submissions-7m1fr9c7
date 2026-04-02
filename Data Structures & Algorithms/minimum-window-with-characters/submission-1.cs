    public class Solution
    {
        public string MinWindow(string s, string t)
        {
            if(t.Length>s.Length) return "";
            Dictionary<char, int> req = new();
            Dictionary<char, int> current = new();
            int have = 0;
            int need = 0;
            int[] resIndexs = new int[2];
            int len = int.MaxValue;
            int l = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (req.ContainsKey(t[i]))
                {
                    req[t[i]]++;
                }
                else
                {
                    req[t[i]] = 1;
                    current[t[i]] = 0;
                    need++;
                }
            }
            for (int r = 0; r < s.Length; r++)
            {
                if (current.ContainsKey(s[r]))
                {
                    current[s[r]]++;
                    if (current[s[r]] == req[s[r]])
                    {
                        have++;
                    }
                }
                while (have == need)
                {
                    int w = (r - l) + 1;
                    Console.WriteLine(w);
                    if (w < len)
                    {
                        resIndexs[0] = l; resIndexs[1] = r;
                        len = w;
                    }
                    if (current.ContainsKey(s[l]))
                    {
                        Console.WriteLine(s[l]);
                        current[s[l]]--;
                        if (current[s[l]] < req[s[l]])
                        {
                            have--;
                        }
                    }
                    l++;
                }
            }
            if(len>s.Length) return ""; 
            return s.Substring(resIndexs[0],len);
        }
    }
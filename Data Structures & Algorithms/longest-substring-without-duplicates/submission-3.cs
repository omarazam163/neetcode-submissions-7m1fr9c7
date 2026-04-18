public class Solution {
            public int LengthOfLongestSubstring(string s)
            {
                int l = 0;
                HashSet<char> list = new HashSet<char>();
                int max = 0;
                for (int r = 0; r < s.Length; r++) {
                    while (list.Contains(s[r]))
                    {
                        list.Remove(s[l]);
                        l++;
                    }
                    list.Add(s[r]);
                    int w = (r - l) + 1;
                    if (w > max) max = w;
                }
                return max;
            }
}

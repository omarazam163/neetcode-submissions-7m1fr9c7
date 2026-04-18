public class Solution {
        public int LengthOfLongestSubstring(string s)
        {
            var l = -1;
            var r = 0;
            var dic = new Dictionary<char, int>();
            var max = int.MinValue;
            for (r = 0; r < s.Length; r++)
            {
                dic[s[r]] = dic.GetValueOrDefault(s[r]) + 1;

                while (! dic.All(x => x.Value == 1))
                {
                    l++;
                    dic[s[l]]--;
                    if (dic[s[l]] == 0)
                    {
                        dic.Remove(s[l]);
                    }
                }

                max = Math.Max(max, r - l);
            }
            return Math.Max(max, 0);
        }
}

public class Solution {
        public int CharacterReplacement(string s, int k)
        {
            var r = 0;
            var l = -1;
            var maxf = 0;
            var maxLength = 0;
            var dic = new Dictionary<char, int>();
            for (r = 0; r < s.Length; r++)
            {
                dic[s[r]] = dic.GetValueOrDefault(s[r]) + 1;
                maxf = Math.Max(dic[s[r]], maxf);
                var w = r - l;
                while (w - maxf > k)
                {
                    l++;
                    dic[s[l]]--;
                    if (dic[s[l]] == 0)
                        dic.Remove(s[l]);
                    w = r - l;
                }
                maxLength = Math.Max(maxLength, w);
            }

            return maxLength;
        }
}

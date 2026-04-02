public class Solution {
    
            public int CharacterReplacement(string s, int k)
            {
                int l = 0;
                Dictionary<char, int> dic = new();
                int maxf = 1;
                int max = 0;
                for (int r = 0; r < s.Length; r++) { 
                 int w = (r - l) + 1;
                    if (dic.ContainsKey(s[r]))
                    {
                        dic[s[r]]++;
                        if (dic[s[r]] > maxf) maxf = dic[s[r]];
                    }
                    else
                    {
                        dic.Add(s[r], 1);
                    }
                    while (w-maxf>k)
                    {
                        dic[s[l]]--;
                        l++;
                        w = (r - l) + 1;
                    }
                 if(w>max) max= w;
                }
                return max;
            }
}

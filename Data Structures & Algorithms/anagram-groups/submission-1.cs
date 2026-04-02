public class Solution {
        public List<List<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> res = new();
            foreach(string s in strs)
            {
                int[] count = new int[26];
                foreach(char c in s)
                {
                    count[c-'a']++;
                }
                var key =string.Join(',',count);
                if(res.ContainsKey(key))
                {
                    res[key].Add(s);
                }
                else
                {
                    res.Add(key,new List<string>(){s});
                }
            }
            return res.Values.ToList();
        }
}

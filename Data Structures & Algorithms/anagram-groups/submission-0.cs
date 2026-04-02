public class Solution {
            static bool compare(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
            return true;
        }
        public List<List<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<int[], List<string>> res = new();
            foreach(string s in strs)
            {
                int[] count = new int[26];
                foreach(char c in s)
                {
                    count[c-'a']++;
                }
                foreach(var item in res)
                {
                    if (compare(item.Key, count))
                    {
                        item.Value.Add(s);
                        goto end;
                    }
                }
                res.Add(count, new List<string> { s });
                end:;
            }
            return res.Values.ToList();
        }
}

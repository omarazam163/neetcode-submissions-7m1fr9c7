public class Solution {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s2.Length < s1.Length)
                return false;
            var dic1 = new Dictionary<char, int>();
            var dic2 = new Dictionary<char, int>();

            for (int i = 0; i < s1.Length; i++)
            {
                dic1[s1[i]] = dic1.GetValueOrDefault(s1[i]) + 1;
            }

            var r = s1.Length;
            var l = -1;

            for (int i = 0; i < s1.Length; i++)
            {
                dic2[s2[i]] = dic2.GetValueOrDefault(s2[i]) + 1;
            }

            for (r = s1.Length; r < s2.Length; r++)
            {
                if (DictionariesEqual(dic1, dic2))
                    return true;
                dic2[s2[r]] = dic2.GetValueOrDefault(s2[r]) + 1;
                l++;
                dic2[s2[l]]--;
                if (dic2[s2[l]] == 0)
                    dic2.Remove(s2[l]);
            }
            return DictionariesEqual(dic1, dic2);
        }

        public bool DictionariesEqual(Dictionary<char, int> dic1, Dictionary<char, int> dic2)
        {
            if (dic1.Count != dic2.Count)
                return false;
            foreach (var key in dic1.Keys)
            {
                if (!dic2.ContainsKey(key))
                    return false;
                else if (dic1[key] != dic2[key])
                    return false;
            }
            return true;
        }
}

public class Solution {
        public bool IsAnagram(string s, string t)
        {
           var hashMap1 = ToDictionaryCount(s);
           var hashMap2 = ToDictionaryCount(t);

           if(hashMap1.Count != hashMap2.Count)
           {
              return false;
           }

           foreach(var key in hashMap1.Keys)
           {
              if (!hashMap2.ContainsKey(key) || !(hashMap2[key] == hashMap1[key]))
              {
                return false;
              }
           }
           return true;
        }

        public Dictionary<char, int> ToDictionaryCount(string ngram)
        {
            var hashMap = new Dictionary<char, int>();
            foreach(var c in ngram)
            {
                if(hashMap.ContainsKey(c))
                {
                    hashMap[c]++;
                }
                else
                {
                    hashMap[c] = 1;
                }
            }
            return hashMap;
        }
}

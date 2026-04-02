public class Solution {
        public List<List<string>> GroupAnagrams(string[] strs)
        {
            var Dictionary = new Dictionary<string, List<string>>();
            foreach(var word in strs)
            {
                var key = string.Join(",", word.ToCharArray().Order());
                if (Dictionary.ContainsKey(key))
                {
                    Dictionary[key].Add(word);
                }
                else
                {
                    Dictionary.Add(key, new List<string>() { word });
                }
            }
            return Dictionary.Values.ToList();
        }
}

public class Solution {
                public int LongestConsecutive(int[] nums)
            {
                HashSet<int> hashed=nums.ToHashSet();
                Dictionary<int,List<int>> keyValuePairs = new Dictionary<int,List<int>>();
                foreach (int i in hashed) {
                    if (!hashed.Contains(i-1))
                    {
                        keyValuePairs.Add(i, new List<int>() { i});
                    }
                }
                foreach(var x in keyValuePairs.Keys) {
                    while (hashed.Contains(keyValuePairs[x][keyValuePairs[x].Count-1]+1))
                    {
                        keyValuePairs[x].Add(keyValuePairs[x][keyValuePairs[x].Count - 1] + 1);
                    }
                }
                int max = 0;
                foreach (var x in keyValuePairs.Values) { 
                 if(max<x.Count())
                        { max = x.Count(); }
                }
                return max;
            }
}

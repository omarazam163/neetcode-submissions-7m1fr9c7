public class Solution {
            public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> hashmap = new();
            List<int> res = new();
            foreach (int num in nums)
            {
                if (hashmap.ContainsKey(num))
                {
                    hashmap[num]++;
                }
                else
                {
                    hashmap.Add(num, 1);
                }
            }
            var bucketArray = new List<int>[nums.Length];
            foreach (var t in hashmap)
            {
                if (bucketArray[t.Value-1] == null)
                {
                    bucketArray[t.Value-1] = new List<int>();
                    bucketArray[t.Value - 1].Add(t.Key);
                }
                else
                    bucketArray[t.Value-1].Add(t.Key);
            }
            for (int i = bucketArray.Length - 1; i >= 0; i--)
            {
                if (bucketArray[i]!=null)
                {
                    res.AddRange(bucketArray[i]);
                }
                if (res.Count >= k)
                {
                    break;
                }
            }
            return res.ToArray();
        }
}

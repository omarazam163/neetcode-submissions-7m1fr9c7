    public class Solution
    {
                public int[] TopKFrequent(int[] nums, int k)
        {
            var hashMap = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!hashMap.ContainsKey(num))
                {
                    hashMap.Add(num, 1);
                }
                else
                {
                    hashMap[num]++;
                }
            }
            var res = new List<int>();
            var hasmMapInverted = new Dictionary<int, List<int>>();
            foreach (var pair in hashMap)
            {
                if (hasmMapInverted.ContainsKey(pair.Value))
                {
                    hasmMapInverted[pair.Value].Add(pair.Key);
                }
                else
                {
                    hasmMapInverted.Add(pair.Value, new List<int>() { pair.Key });
                }
            }

            for(int i = nums.Length; i > 0; i--)
            {
                if (hasmMapInverted.TryGetValue(i, out List<int> values))
                {
                    res.AddRange(values);
                    if (res.Count >= k)
                    {
                        break;
                    }
                }
            }
            return res.ToArray();
        }
    }
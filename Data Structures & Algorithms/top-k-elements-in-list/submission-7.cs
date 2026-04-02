    public class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            var freqMap = new Dictionary<int, int>();
            var InvertedFreqMap = new List<int>[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (!freqMap.TryAdd(nums[i],1))
                {
                    freqMap[nums[i]]++;
                }
            }
            foreach (var kvp in freqMap)
            {
                int freq = kvp.Value;
                if (InvertedFreqMap[freq-1] == null)
                {
                    InvertedFreqMap[freq-1] = new List<int>();
                }
                InvertedFreqMap[freq-1].Add(kvp.Key);
            }
            var result = new List<int>();
            for (int i = InvertedFreqMap.Length - 1; i >= 0 && result.Count < k; i--)
            {
                if (InvertedFreqMap[i] != null)
                {
                    result.AddRange(InvertedFreqMap[i]);
                }
                if (result.Count == k)
                {
                    break;
                }
            }
            return result.ToArray();
        }
    }
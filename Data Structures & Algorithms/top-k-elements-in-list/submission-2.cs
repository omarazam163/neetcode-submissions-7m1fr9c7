public class Solution {
                public int[] TopKFrequent(int[] nums, int k)
            {
                Dictionary<int,int> hashmap = new();
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
                Dictionary<int, int> sorted = hashmap.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                foreach (var item in sorted)
                {
                    if (k == 0)
                    {
                        break;
                    }
                    res.Add(item.Key);
                    k--;
                }
                return res.ToArray();
            }
}

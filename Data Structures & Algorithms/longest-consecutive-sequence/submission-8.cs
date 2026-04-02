public class Solution {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            var set = new HashSet<int>(nums);
            var dic = new Dictionary<int, int>();

            foreach(var num in nums)
            {
                if(!set.Contains(num - 1))
                {
                    dic[num] = 1;
                }
            }
            var max = 1;
            foreach(var key in dic.Keys)
            {
                while(set.Contains(key + dic[key]))
                {
                    dic[key] += 1;
                    if (dic[key] > max)
                    {
                        max = dic[key];
                    }
                }
            }

            return max;
        }
}

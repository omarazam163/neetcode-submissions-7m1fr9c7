    public class Solution
    {
        public int Jump(int[] nums)
        {
            int jumps = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1) continue;
                int max = int.MinValue;
                int maxIndex = 0;
                if (nums[i] + i >= nums.Length-1)
                {
                    jumps++;
                    break;
                }
                for (int j = i + 1; j <= i + nums[i]; j++)
                {
                    if (nums[j] >= max)
                    {
                        max = nums[j];
                        maxIndex = j;
                    }
                }
                i = maxIndex - 1;
                jumps++;
            }
            return jumps;
        }
    }

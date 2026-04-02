    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum > max) max = sum;
                }
            }
            return max;
        }
    }
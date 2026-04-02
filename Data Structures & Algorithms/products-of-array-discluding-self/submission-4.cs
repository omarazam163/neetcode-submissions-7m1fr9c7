    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var suffix = new int[nums.Length];
            var prefix = new int[nums.Length];
            var res = new int[nums.Length];
            suffix[nums.Length- 1] = 1;
            prefix[0] = 1;
            for(int i=1;i<nums.Length;i++)
            {
                prefix[i] = nums[i-1] * prefix[i-1];
            }

            for(int i=nums.Length-2;i>=0;i--)
            {
                suffix[i] = nums[i+1] * suffix[i+1];
            }

            for(int i=0;i<nums.Length;i++)
            {
                res[i] = prefix[i] * suffix[i];
            }

            return res;
        }

    }

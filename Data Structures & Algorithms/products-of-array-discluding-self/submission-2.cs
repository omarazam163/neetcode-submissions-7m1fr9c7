    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int countZero = 0;
            long x = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) countZero++;
                if(nums[i]!=0)
                {
                    x *= nums[i];
                }
            }
            if (countZero > 1) return new int[nums.Length];
            else if (countZero == 1)
            {
                var result = new int[nums.Length];
                result[Array.IndexOf(nums, 0)] = (int)x;
                return result;
            }
            else
            {
                var result = new int[nums.Length];
                for (int i=0;i<nums.Length;i++)
                {
                    result[i] = (int)(x / nums[i]); 
                }
                return result;
            }
        }
    }
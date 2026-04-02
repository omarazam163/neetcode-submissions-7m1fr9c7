    public class Solution
    {
        public int Jump(int[] nums)
        {
            int l=0,r = 0;
            int jumps = 0;
            while (r < nums.Length-1)
            {
                int far = 0;
                for (int j = l; j <= r; j++)
                {
                    far = Math.Max(far, j + nums[j]);
                }
                l = r + 1;
                r = far;
                jumps++;
            }
            return jumps;
        }
    }
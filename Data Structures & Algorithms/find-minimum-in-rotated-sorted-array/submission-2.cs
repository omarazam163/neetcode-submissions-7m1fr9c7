public class Solution {
            public int FindMin(int[] nums)
        {
            int l = 0;
            int r = nums.Length - 1;
            int res = nums[0];
            while(r>=l)
            {
                if (nums[r] > nums[l])
                {
                    return Math.Min(res, nums[l]);
                }
                int m = (r+l)/2;
                res = Math.Min(res, nums[m]);
                if (nums[m] >= nums[l])
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
            return res;
        }
}

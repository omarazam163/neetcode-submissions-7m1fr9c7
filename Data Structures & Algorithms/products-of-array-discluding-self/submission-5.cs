public class Solution {
        public int[] ProductExceptSelf(int[] nums)
        {
            int pre = 1;
            int post = 1;
            var res = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = pre;
                pre *= nums[i];
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                res[i] *= post;
                post *= nums[i];
            }

            return res;
        }
}

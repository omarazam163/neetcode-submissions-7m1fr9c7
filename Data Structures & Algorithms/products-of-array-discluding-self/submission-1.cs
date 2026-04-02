public class Solution {
            public int[] ProductExceptSelf(int[] nums)
            {
                int[] res = new int[nums.Length];
                res[0] = 1;
                int pre = 1;
                int post = 1;
                for (int i = 1; i < nums.Length; i++)
                {
                    pre= pre * nums[i - 1];
                    res[i] = pre;
                }
                for (int i = nums.Length - 2; i >= 0; i--)
                {

                    post *= nums[i + 1];
                    res[i] *= post;
                }
                return res;
            }
}

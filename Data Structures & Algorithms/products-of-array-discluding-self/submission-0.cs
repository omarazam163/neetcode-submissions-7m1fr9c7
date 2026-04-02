public class Solution {
                public int[] ProductExceptSelf(int[] nums)
            {
                List<int> zeros = new();
                int product = 1;
                int[]res = new int[nums.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 0)
                    {
                        zeros.Add(i);
                    }
                    else
                    {
                        product *= nums[i];
                    }
                }
                if(zeros.Count==1)
                {
                   res[zeros[0]] = product;
                    return res;
                }
                if (zeros.Count >1)
                {
                    return res;
                }
                for (int i = 0; i < nums.Length; i++)
                {
                        res[i] = product / nums[i];
                }
                return res;
            }
}

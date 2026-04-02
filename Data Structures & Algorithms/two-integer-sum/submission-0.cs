    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[]res = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        res[0] = i;
                        res[1] = j;
                    }
                }
            }
            return res.OrderBy((x)=>x).ToArray();
        }
    }
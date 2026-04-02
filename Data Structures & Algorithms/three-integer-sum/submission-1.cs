public class Solution {
            public List<List<int>> ThreeSum(int[] nums)
        {
            nums = nums.OrderBy(x => x).ToArray(); // Sort the array
            List<List<int>> res = new();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int forward = i + 1;
                int backward = nums.Length - 1; 

                while (forward < backward)
                {
                    int sum = nums[i] + nums[forward] + nums[backward];

                    if (sum == 0)
                    {
                        res.Add(new List<int> { nums[i], nums[forward], nums[backward] });
                        while (forward < backward && nums[forward] == nums[forward + 1]) forward++;
                        while (forward < backward && nums[backward] == nums[backward - 1]) backward--;

                        forward++;
                        backward--;
                    }
                    else if (sum < 0)
                    {
                        forward++;
                    }
                    else
                    {
                        backward--;
                    }
                }
            }

            return res;
        }
}

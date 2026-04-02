    public class Solution
    {
        public List<List<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            List<List<int>> res = new();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i-1]) continue;
                int left = i + 1;
                int right = nums.Length - 1;
                while(right>left)
                {
                    int sum = nums[left] + nums[right] + nums[i];
                    if(sum==0)
                    {
                        res.Add(new List<int>() { nums[i], nums[left] , nums[right] });
                        while (right > left && nums[left] == nums[left + 1]) left++;
                        while (right > left && nums[right] == nums[right - 1]) right--;
                        left++;
                        right--;
                    }
                    else if(sum>0)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }
            return res;
        }
    }
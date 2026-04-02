    public class Solution
    {
        int[] nums;
        List<List<int>> res = new();
        List<int> curr = new();
        void solve(int i)
        {
            if(i>nums.Length-1)
            {
                res.Add(new List<int>(curr));
                return;
            }

            //leave 
            solve(i + 1);

            curr.Add(nums[i]);
            solve(i+1);
            curr.RemoveAt(curr.Count-1);
        }
        public List<List<int>> Subsets(int[] nums)
        {
            this.nums = nums;
            solve(0);
            return res;
        }
    }
    public class Solution
    {
        int[] nums;
        List<List<int>> res = new();
        List<int> curr = new();
        bool[] used;
        void solve()
        {
            if (curr.Count == nums.Length)
            {
                res.Add(new List<int>(curr));
            }

            //take
            for (int j = 0; j < nums.Length; j++)
            {
                if (!used[j])
                {
                    used[j] =true;
                    curr.Add(nums[j]);
                    solve();
                    curr.RemoveAt(curr.Count - 1);
                    used[j]=false;
                }
            }
        }
        public List<List<int>> Permute(int[] nums)
        {
            this.nums = nums;
            this.used = new bool[nums.Length];
            solve();
            return res;
        }
    }
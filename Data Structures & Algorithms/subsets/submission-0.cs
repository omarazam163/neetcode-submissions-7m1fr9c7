    public class Solution
    {
        List<int> curr =  new List<int>();
        List<List<int>> final = new();
        int[] nums;
        void solve(int i)
        {
            if(i>=nums.Length)
            {
                final.Add(new List<int>(curr));
                return;
            }

            //leave
            solve(i + 1);

            //take
            curr.Add(nums[i]);
            solve(i+1);
            curr.RemoveAt(curr.Count-1);
        }

        public List<List<int>> Subsets(int[] nums)
        {
            this.nums = nums;
            solve(0);
            return final;
        }
    }
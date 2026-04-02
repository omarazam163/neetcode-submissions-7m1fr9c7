    public class Solution
    {
        HashSet<int> curr = new HashSet<int>();
        List<List<int>> final = new();
        int[] nums;
        void solve(int i)
        {
            if (curr.Count == nums.Length)
            {
                final.Add(curr.ToList());
                return;
            }
            if (i >= nums.Length) return;

            //take
            foreach (var x in nums)
            {
                if (!curr.Contains(x))
                {
                    curr.Add(x);
                    solve(i+1);
                    curr.Remove(x);
                }
            }

            //leave
            solve(i+1);
        }
        public List<List<int>> Permute(int[] nums)
        {
            this.nums = nums;
            solve(0);
            return this.final;
        }
    }

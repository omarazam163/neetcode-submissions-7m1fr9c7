    public class Solution
    {
        int[] nums;
        int target;
        List<int> curr=new();
        List<List<int>> res = new(); 

        void solve(int i,int sum)
        {
            if(sum>=target)
            {
                if(sum==target)
                {
                    res.Add(new List<int>(curr));
                }
                return;
            }
            if (i > nums.Length-1) return;

            //leave 
            solve(i + 1, sum);

            //take
            curr.Add(nums[i]);
            sum = sum + nums[i];
            solve(i, sum);
            sum -= curr.Last();
            curr.RemoveAt(curr.Count-1);
        }
        public List<List<int>> CombinationSum(int[] nums, int target)
        {
            this.nums = nums;
            this.target = target;
            solve(0,0);
            return res;
        }
    }
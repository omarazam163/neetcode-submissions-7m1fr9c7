    public class Solution
    {
        Dictionary<string, List<int>> dic = new();
        int target;
        int[] nums;
        List<int> curr = new();
        void solve(int i, int sum)
        {
            
            if (sum >= target)
            {
                if (sum == target)
                {
                    
                    string Key = String.Join(",", curr);
                    if(!dic.ContainsKey(Key))
                    {
                        dic[Key] = new List<int>(curr);
                    }
                }
                return;
            }
            if (i > nums.Length-1) return;
            //leave 
            solve(i + 1, sum);

            //take 
            curr.Add(nums[i]);
            sum += nums[i];
            solve(i+1, sum);
            sum -= curr.Last();
            curr.RemoveAt(curr.Count - 1);
        }
        public List<List<int>> CombinationSum2(int[] candidates, int target)
        {

            this.target = target;
            Array.Sort(candidates);
            this.nums = candidates;
            solve(0, 0);
            return dic.Values.ToList();
        }
    }

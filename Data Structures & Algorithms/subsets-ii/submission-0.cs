    public class Solution
    {
        HashSet<string> final = new HashSet<string>();
        List<int> curr = new List<int>();
        int[] nums;

        void solve(int i)
        {
            if(i>=nums.Length)
            {
                string val = String.Join(",", curr);
                if(!final.Contains(val))
                {
                    final.Add(val);
                }
                return;
            }


            //take
            curr.Add(nums[i]);
            solve(i+1);
            curr.RemoveAt(curr.Count-1);

            //leave
            solve(i + 1);
        }
        public List<List<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);
            this.nums = nums;
            solve(0);
            List<List<int>> res = final.Where((x)=>x!="").Select(x => x.Split(",").Select((x) => int.Parse(x)).ToList()).ToList();
            res.Add(new List<int>());
            return res;
        }
    }

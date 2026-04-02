        public class Solution
        {
            int target;
            HashSet<string> final = new();
            List<int> curr = new();
            int[] nums;
            void solve(int i,int sum)
            {
                if (target == sum) {
                    string val = string.Join(",", curr);
                    if (!final.Contains(val))
                    {
                       Console.WriteLine(val);
                       final.Add(val);
                    }
                    return;
                };

                if (target < sum) return;
                if (i >= nums.Length) return;

                //take
                curr.Add(nums[i]);
                solve(i + 1, sum + nums[i]);
                curr.RemoveAt(curr.Count - 1);

                //leave
                solve(i + 1, sum);
            }
            public List<List<int>> CombinationSum2(int[] candidates, int target)
            {
                this.target = target;
                Array.Sort(candidates);
                this.nums = candidates;

                solve(0, 0);
                var res = final.ToList().Select((x) => x.Split(",").ToList().Select((x)=>int.Parse(x)).ToList()).ToList();
                return res;
            }
        }

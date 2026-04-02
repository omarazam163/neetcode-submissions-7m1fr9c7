    public class Solution
    {
        int[] costs;
        int res=int.MaxValue;
        Dictionary<int,int> memo = new(); 
        int solve(int i)
        {
            if(memo.ContainsKey(i)) return memo[i];
            if (i >= costs.Length) return 0;
            int oneStep = costs[i] + solve(i+1);
            int twoStep = costs[i]+solve(i+2);
            res = Math.Min(oneStep,twoStep);
            memo[i] =res;
            return memo[i];
        }
        public int MinCostClimbingStairs(int[] cost)
        {
            this.costs = cost;
            return Math.Min(solve(0),solve(1));
        }
    }
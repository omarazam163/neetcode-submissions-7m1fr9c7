    public class Solution
    {
        int count = 0;
        int n;
        Dictionary<int, int> memo = new();
        int solve(int i)
        {
            if (memo.ContainsKey(i)) return memo[i];
            if (i > n) return 0;
            if (i == n) return 1;
            int res = solve(i + 1) + solve(i + 2);
            memo[i] = res;
            return res;
        }
        public int ClimbStairs(int n)
        {
            this.n = n;
            return solve(0);
        }
    }
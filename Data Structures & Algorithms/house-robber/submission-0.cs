    public class Solution
    {
       int[] nums;
       int max = int.MinValue;
       Dictionary<int, int> memo = new();
       int Solve(int i)
       {
           if (memo.ContainsKey(i)) return memo[i];
           if (i >= nums.Length)
           {
               return 0;
           }
           int leave = Solve(i + 1);
           int take = nums[i] + Solve(i + 2);
           memo[i] = Math.Max(take, leave);
           return memo[i];
       }
       public int Rob(int[] nums)
       {
           this.nums = nums;
           return Solve(0);
       }
    }
public class Solution {
    public int MaxProfit(int[] prices) {
      if (prices.Length < 2)
        return 0;

      var l = 0;
      var r = 1;
      var maxProfit = prices[r] - prices[l];

while (r < prices.Length)
{
    if (prices[r] < prices[l])
    {
        l = r; // reset buy point
    }
    else
    {
        maxProfit = Math.Max(maxProfit, prices[r] - prices[l]);
    }

    r++;
}

      return Math.Max(0 , maxProfit);
    }
}

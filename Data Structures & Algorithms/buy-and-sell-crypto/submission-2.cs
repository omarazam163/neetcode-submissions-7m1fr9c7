        public class Solution
        {
            public int MaxProfit(int[] prices)
            {
                if(prices.Length==1) return 0;
                int l = 0;
                int max = 0;
                for(int r = 0;r<prices.Length;r++)
                {
                    int current = prices[r]-prices[l];
                    while( current < 0)
                    {
                        l++;
                        current = prices[r] - prices[l];
                    }
                    if(current > max) max = current;
                }
                return max;
            }
        }
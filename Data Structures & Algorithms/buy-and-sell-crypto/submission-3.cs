        public class Solution
        {
            public int MaxProfit(int[] prices)
            {
                if(prices.Length==1) return 0;
                int l = 0;
                int r = 1;
                int max = 0;
                while(r<prices.Length){
                    int current = prices[r] - prices[l];
                    if (current >= 0)
                    {
                        r++;
                    }
                    else
                    {
                        l++;
                    }
                    if (current > max) max = current;
                }
                return max;
            }
        }
public class Solution {
        public int MinEatingSpeed(int[] piles, int h)
        {
            if(piles.Length==1) return (int)Math.Ceiling((double)piles[0] / h);
            int max = piles.Max();
            int l = 1;
            int r = max;
            int sol = max;
            while(l<=r)
            {
                int m = (l + r) / 2;
                int sum = 0;
                for (int i = 0; i < piles.Length; i++) { 
                 sum += (int)Math.Ceiling((double)piles[i]/m);
                    if (sum > h) break;
                }

                if(sum<=h)
                {
                    sol = m;
                    r = m - 1;
                }
                else
                {
                    l = m + 1;
                }
            }
            return sol;
        }
}

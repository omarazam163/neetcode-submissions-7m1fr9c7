public class Solution {
            public int MinEatingSpeed(int[] piles, int h)
        {
            if (piles.Length == 1) return (int)Math.Ceiling((decimal)piles[0] / h);
            int max = piles.Max();
            int l = 1;
            int r = max;
            int sol = 0;
            while(l<=r)
            {
                int m = (l + r) / 2;
                int sum = 0;
                foreach(int pile in piles)
                {
                    sum += (int)Math.Ceiling((decimal)pile / m);
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

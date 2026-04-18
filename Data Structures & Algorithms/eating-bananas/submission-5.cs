public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        var r = piles.Max();
        var l = 0;
        while (r > l)
        {
            var m = (r + l) / 2;
            var hoursTaken = 0; 
            foreach (var pile in piles)
            {
                hoursTaken += (int)Math.Ceiling((double)pile / m);
            }

            if (hoursTaken <= h)
            {
                r = m;
            }
            else
            {
                l = m +1;
            }
        }

        return l;
    }
}

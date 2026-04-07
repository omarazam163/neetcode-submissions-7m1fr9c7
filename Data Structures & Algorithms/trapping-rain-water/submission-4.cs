public class Solution {
        public int Trap(int[] height)
        {
            if (height.Length < 3)
                return 0;
            var l = 0;
            var r = height.Length - 1;
            var maxL = height[l];
            var maxR = height[r];
            var res = new int[height.Length];
            while (l <= r)
            {
                if (maxL < maxR)
                {
                    if (maxL > height[l])
                        res[l] = maxL - height[l];
                    maxL = Math.Max(maxL, height[l]);
                    l++;
                }
                else
                {
                    if (maxR > height[r])
                        res[r] = maxR - height[r];
                    maxR = Math.Max(maxR, height[r]);
                    r--;
                }
            }
            return res.Sum();
        }
}

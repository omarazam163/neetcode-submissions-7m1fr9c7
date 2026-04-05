public class Solution {
        public int MaxArea(int[] heights)
        {
            var max = int.MinValue;
            var l = 0;
            var r = heights.Length - 1;
            while (l < r)
            {
                var current = int.Min(heights[l], heights[r]) * (r - l);
                if (current > max) max = current;
                if (heights[l] > heights[r])
                    r--;
                else if (heights[r] >= heights[l])
                    l++;
            }
            return max;
        }
}

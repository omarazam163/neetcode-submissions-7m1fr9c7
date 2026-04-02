    public class Solution
    {
        public int Trap(int[] height)
        {
            int sum = 0;
            for (int i = 0; i < height.Length; i++) {
                int right = 0;
                int left = height.Length - 1;
                int maxRight = 0;
                int maxLeft= 0;
                while (right < i)
                {
                    if (height[right]>maxRight) maxRight = height[right];
                    right++;
                }
                while (left > i) {
                    if (height[left] > maxLeft) maxLeft = height[left];
                    left--;
                }
                if (Math.Min(maxRight, maxLeft) - height[i]>0)
                {
                    sum += Math.Min(maxRight, maxLeft) - height[i];
                }
            }
            return sum;
        }
    }
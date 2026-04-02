    public class Solution
    {
        public int Trap(int[] height)
        {
            int left= 0;
            int right= height.Length-1;
            int maxLeft = height[0];
            int maxright = height[height.Length-1];
            int sum= 0;
            for (int i = 1; i < height.Length - 1; i++) { 
             if(maxLeft<=maxright)
                {
                    left++;
                    int val = maxLeft-height[left];
                    if(val>0) sum+= val;
                    if (height[left]>maxLeft) maxLeft=height[left];
                }
                else
                {
                    right--;
                    int val = maxright-height[right];
                    if (val>0) sum+= val;
                    if (height[right] > maxright) maxright = height[right];
                }
            }
            return sum;
        }
    }
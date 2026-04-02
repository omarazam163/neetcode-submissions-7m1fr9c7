    public class Solution
    {
        public int LargestRectangleArea(int[] heights)
        {
            Stack<int[]> stack = new();
            int max = 0;
            stack.Push(new int[] { heights[0], 0 });
            for (int i = 1; i < heights.Length; i++) {
                int start = i;
                while(stack.Count!=0&&stack.Peek()[0] > heights[i])
                {
                    int[] temp = stack.Pop();
                    if (max < (i-temp[1]) * temp[0])
                    {
                        max = (i - temp[1]) * temp[0];
                    }
                    start = temp[1];
                }
                stack.Push(new int[] { heights[i], start });
            }
            if(stack.Count!=0)
            {
                foreach(int[] temp in stack)
                {
                    int area = ((heights.Length)-temp[1])*temp[0];
                    if(max<area)
                    {
                        max= area;
                    }
                }
            }
            return max;
        }
    }
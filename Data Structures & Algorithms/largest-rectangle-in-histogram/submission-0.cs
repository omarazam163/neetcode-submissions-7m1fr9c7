    public class Solution
    {
        public int LargestRectangleArea(int[] heights)
        {
            Stack<int[]> stack = new();
            int max = 0;
            stack.Push(new int[] { heights[0], 0 });
            for (int i = 1; i < heights.Length; i++) {
                int l = 0;
                if (stack.Peek()[0] <= heights[i])
                {
                    stack.Push(new int[] { heights[i], i });
                    continue;
                }
                while(stack.Count!=0&&stack.Peek()[0] > heights[i])
                {
                    int[] temp = stack.Pop();
                    if (max < (i-temp[1]) * temp[0])
                    {
                        max = (i - temp[1]) * temp[0];
                    }
                    l = temp[1];
                }
                stack.Push(new int[] { heights[i], l });
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
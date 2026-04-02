public class Solution {
            public int MaxArea(int[] heights)
        {
            int front = 0;
            int rear = heights.Length-1;
            int max = Math.Min(heights[rear], heights[front]) * (rear - front);
            while (rear>front)
            {
                if (max < Math.Min(heights[rear], heights[front]) * (rear - front))
                {
                    max = Math.Min(heights[rear], heights[front]) * (rear - front);
                }
                if(heights[rear] > heights[front])
                {
                    front++;
                }
                else if(heights[rear] < heights[front])
                {
                    rear--;
                }
                else
                {
                    front++;
                    rear--;
                }
            }
            return max;
        }
}

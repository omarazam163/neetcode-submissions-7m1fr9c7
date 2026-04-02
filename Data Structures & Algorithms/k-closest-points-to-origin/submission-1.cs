    public class Solution
    {
        double calculateDistance(int x,int y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + (Math.Pow(y, 2)));
        }
        public int[][] KClosest(int[][] points, int k)
        {
            PriorityQueue<int[], double> que = new();
            for(int i=0;i<points.Length;i++)
            {
                double dis = calculateDistance(points[i][0], points[i][1]);
                que.Enqueue(points[i],-dis);
                if(que.Count>k)
                {
                    que.Dequeue();
                }
            }
            int[][] res = new int[k][];
            for(int i=0;i<k;i++)
            { 
                res[i] = que.Dequeue();
            }
            return res;
        }
    }
    public class Solution
    {
        public int LastStoneWeight(int[] stones)
        {
            PriorityQueue<int,int> que = new();
            for(int i =0;i<stones.Length;i++)
            {
                que.Enqueue(stones[i], -stones[i]);
            }
            
            while(que.Count>=2)
            {
                int stone1 = que.Dequeue();
                int stone2 = que.Dequeue();
                if(stone1!=stone2)
                {
                    int newStone = Math.Abs(stone1 - stone2);
                    que.Enqueue(newStone,-newStone);
                }
            }
            return (que.Count == 1) ? que.Dequeue() : 0;
        }
    }
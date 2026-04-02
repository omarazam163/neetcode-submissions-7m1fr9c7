    public class Solution
    {
        public int LeastInterval(char[] tasks, int n)
        {
            PriorityQueue<int, int> priQue = new();
            Queue<KeyValuePair<int, int>> que = new();
            int time = 0;
            int[] counts = new int[26];
            for(int i=0;i<tasks.Length;i++)
            {
                counts[tasks[i] - 'A']++;
            }
            for(int i=0;i<counts.Length;i++)
            {
                if(counts[i]>0)
                {
                    priQue.Enqueue(counts[i], -counts[i]);
                }
            }
            while (priQue.Count > 0 || que.Count>0)
            {
                time++;
                if(priQue.Count > 0)
                {
                int NextTime = priQue.Dequeue() - 1;
                if (NextTime > 0)
                {
                    que.Enqueue(new KeyValuePair<int, int>(NextTime, time + n));
                }
                }
                if (que.Count > 0)
                {
                    if (que.Peek().Value == time)
                    {
                        int newTask = que.Dequeue().Key;
                        priQue.Enqueue(newTask, -newTask);
                    }
                }
            }

            return time;
        }
    }
    public class KthLargest
    {
        PriorityQueue<int,int> que;
        int k;
        public KthLargest(int k, int[] nums)
        {
            this.k = k;
            this.que = new();
            for(int i=0;i<nums.Length;i++)
            {
                que.Enqueue(nums[i], nums[i]);
                if(que.Count>k)
                {
                    que.Dequeue();
                }
            }
        }

        public int Add(int val)
        {
            que.Enqueue(val,val);
            if (que.Count > k)
            {
                que.Dequeue();
            }
            return que.Peek();
        }
    }
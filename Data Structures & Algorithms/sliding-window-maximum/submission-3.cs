    public class Solution
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            LinkedList<int> que = new();
            int[] arr = new int[nums.Length - (k - 1)];
            int l = 0;
            int index = 0;
            for (int r = 0; r < nums.Length; r++)
            {
                while (que.Count > 0 && nums[que.Last.Value] < nums[r])
                {
                    Console.WriteLine(que.First());
                    que.RemoveLast();
                }
                que.AddLast(r);
                if (l > que.First.Value)
                {
                    que.RemoveFirst();
                }
                if (r + 1 >= k)
                {

                    arr[index] = nums[que.First.Value];
                    index++;
                    l++;
                }
            }
            return arr;
        }
    }

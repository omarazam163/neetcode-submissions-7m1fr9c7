    public class LRUCache
    {
        LinkedList<int[]> que;
        Dictionary<int, LinkedListNode<int[]>> dic;
        int capacity;
        public LRUCache(int capacity)
        {
            que = new();
            dic = new();
            this.capacity = capacity;
        }

        public int Get(int key)
        {
            if(dic.ContainsKey(key))
            {
                que.Remove(dic[key]);
                que.AddLast(dic[key]);
                return dic[key].Value[1];
            }
            else
            {
                return -1;
            }
        }

        public void Put(int key, int value)
        {
            if(dic.ContainsKey(key))
            {
                dic[key].Value[1] = value;
                que.Remove(dic[key]);
                que.AddLast(dic[key]);   
            }
            else
            {
                if (que.Count >= capacity)
                {
                    dic.Remove(que.First.Value[0]);
                    que.RemoveFirst();
                }
                LinkedListNode<int[]> newNode= new(new int[] {key,value });
                dic[key] = newNode;
                que.AddLast(newNode);
            }
        }
    }

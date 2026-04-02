public class Solution {
            struct node
        {
            public string content { set; get; }
            public int open { set; get; }
            public int close { set; get; }
            public node(string content,int open,int close)
                {
                this.content = content;
                this.close = close;
                this.open = open;
                }
        }
        public List<string> GenerateParenthesis(int n)
        {
            Queue<node> que = new();
            node first = new("(",1,0);
            que.Enqueue(first);
            List<string> res = new();
            while(que.Count!=0)
            {
                node current = que.Dequeue();
                if(current.open==n && current.close==n)
                {
                    res.Add(current.content);
                    continue;
                }
                if (current.open < n)
                {
                    node temp = current;
                    temp.content += "(";
                    temp.open += 1;
                    que.Enqueue(temp);
                }
                if (current.close<current.open)
                {
                    node temp = current;
                    temp.content += ")";
                    temp.close += 1;
                    que.Enqueue(temp);
                }
            }
            return res;
        }
}
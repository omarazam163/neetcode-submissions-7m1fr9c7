public class Solution {
        class temp
        {
            public int content { set; get; }
            public int index;
            public temp(int content,int index) {
            this.content = content; this.index = index;
            }
        }
        public int[] DailyTemperatures(int[] temperatures)
        {
            Stack<temp> stack = new Stack<temp>();
            int[]res= new int[temperatures.Length];
            stack.Push(new temp(temperatures[0],0));
            for(int i=1;i<temperatures.Length;i++)
            {
                while(stack.Count>0&&stack.Peek().content < temperatures[i])
                {
                    res[stack.Peek().index] = i - stack.Peek().index;
                    stack.Pop();
                }
                stack.Push(new temp(temperatures[i],i));
            }
            return res;
        }
}

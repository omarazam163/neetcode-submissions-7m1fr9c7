public class Solution {
        public int[] DailyTemperatures(int[] temperatures)
        {
            Stack<Tuple<int,int>> stack = new Stack<Tuple<int,int>>();
            int[]res= new int[temperatures.Length];
            stack.Push(new Tuple<int,int>(temperatures[0],0));
            for(int i=1;i<temperatures.Length;i++)
            {
                while(stack.Count>0&&stack.Peek().Item1 < temperatures[i])
                {
                    res[stack.Peek().Item2] = i - stack.Peek().Item2;
                    stack.Pop();
                }
                stack.Push(new Tuple<int, int>(temperatures[i], i));
            }
            return res;
        }
}

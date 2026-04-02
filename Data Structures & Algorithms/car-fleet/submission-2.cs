public class Solution {
        public int CarFleet(int target, int[] position, int[] speed)
        {
            var sorted = position.Select((x, index) => new Tuple<int, int>(x, speed[index])).OrderByDescending((x) => x.Item1).ToArray();
            Stack<double> stack = new();
            stack.Push((float)(target - sorted[0].Item1) / sorted[0].Item2);
            int count = 1;
            for(int i=1;i<position.Length;i++)
            {
                if((float)(target - sorted[i].Item1) / sorted[i].Item2<=stack.Peek())
                {
                    continue;
                }
                else
                {
                    stack.Push((float)(target - sorted[i].Item1) / sorted[i].Item2);
                    count++;
                }
            }
            return count;
        }
}

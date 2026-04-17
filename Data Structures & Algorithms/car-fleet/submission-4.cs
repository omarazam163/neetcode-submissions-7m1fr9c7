public class Solution {
        public int CarFleet(int target, int[] position, int[] speed)
        {
            var pairs = position.Zip(speed).OrderBy(x => x.First).ToList();

            var stack = new Stack<double>();

            for (int i = pairs.Count - 1; i >= 0; i--)
            {
                var currentPos = pairs[i].First;
                var currentSpeed = pairs[i].Second;
                var timeToTarget = (double)(target - currentPos) / currentSpeed;
                if (stack.Count == 0)
                    stack.Push(timeToTarget);
                else
                {
                    var peek = stack.Peek();

                    if (timeToTarget > peek)
                    {
                        stack.Push(timeToTarget);
                    }
                }
            }

            return stack.Count;
        }
}

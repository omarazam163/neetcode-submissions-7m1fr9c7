public class Solution {
        public int[] DailyTemperatures(int[] temperatures)
        {
            var res = new int[temperatures.Length];
            var monoStack = new Stack<(int item, int index)>();

            for (int i = 0; i < temperatures.Length; i++)
            {
                if (monoStack.Count > 0)
                {
                    while (monoStack.TryPeek(out (int item, int index) peek) && peek.item < temperatures[i])
                    {
                        var oldpeek = monoStack.Pop();
                        res[oldpeek.index] = i - oldpeek.index;
                    }
                    monoStack.Push((temperatures[i], i));
                }
                else
                {
                    monoStack.Push((temperatures[i], i));
                }
            }

            return res;
        }
}

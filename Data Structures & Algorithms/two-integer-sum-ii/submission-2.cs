public class Solution {
        public int[] TwoSum(int[] numbers, int target)
        {
            var start = 0;
            var end = numbers.Length - 1;

            while(start < end)
            {
                var current = numbers[start] + numbers[end]; 
                if(current > target)
                   end--;
                else if(current < target)
                   start++;
                else
                   return [start+1, end+1];
            }

            return [0,0];
        }
}

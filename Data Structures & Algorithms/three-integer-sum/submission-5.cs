public class Solution {
        public List<List<int>> ThreeSum(int[] nums)
        {
            var sorted = nums.Order().ToArray();
            var res = new List<List<int>>();
            var i = 0;
            for (i = 0; i < sorted.Length - 2; i++)
            {
                while (i > 0 && i < sorted.Length - 2 && sorted[i] == sorted[i - 1]) i++;
                var left = i + 1;
                var right = sorted.Length - 1;
                while (left < right)
                {
                    var sum = sorted[i] + sorted[left] + sorted[right];
                    if (sum == 0)
                    {
                        res.Add(new List<int>() { sorted[i], sorted[left], sorted[right] });
                        while (left < right && sorted[left] == sorted[left + 1]) left++;
                        while (left < right && sorted[right] == sorted[right - 1]) right--;
                        left++;
                        right--;
                    }
                    else if (sum > 0) right--;
                    else
                        left++;
                }
            }
            return res;
        }
}

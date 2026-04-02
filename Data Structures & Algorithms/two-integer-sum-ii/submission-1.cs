public class Solution {
            public int[] TwoSum(int[] numbers, int target)
        {
            int f = 0;
            int l = numbers.Length-1;
            int[] res = new int[2];
            while(f<l)
            {
                int temp = numbers[f] + numbers[l];
                if (temp == target)
                {
                    res[0] = f+1; res[1] = l+1;
                    break;
                }
                else if (temp > target) l--;
                else if (temp < target) f++;
            }
            return res;
        }
}

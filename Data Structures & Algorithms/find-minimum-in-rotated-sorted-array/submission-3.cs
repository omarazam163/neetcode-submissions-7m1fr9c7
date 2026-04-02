public class Solution {
            public int FindMin(int[] nums)
        {
            int l = 0;
            int r = nums.Length - 1;
            int res = nums[0];
        while (l < r) {
            Console.WriteLine(l);
            int m = (l + r) / 2;
            if (nums[m] > nums[r]) {
                l = m + 1;
            } else {
                r = m;
            }
        }
        return nums[l];
        }
}
